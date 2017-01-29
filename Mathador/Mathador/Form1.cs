using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using Generator;

namespace Mathador
{
    public partial class Form1 : Form
    {
        private List<String> operationArray = new List<String>();
        private string operation = "";
        private List<List<Button>> operationButtonsList = new List<List<Button>>();
        private List<List<String>> operationButtonsValuesList = new List<List<string>>();
        private List<string> scoreList = new List<string>();
        private List<Button> operationButtons = new List<Button>();
        private List<String> arrayOperators = new List<String>();
        // Initialisation du timer à 3 minutes soit 180 secondes
        private int duration;

        // Constructeur du Window Form
        public Form1()
        {
            InitializeComponent();
            showHomePanel();

            // Création de la base de données locale
            SQLiteConnection.CreateFile("database.sqlite");
        }
        
        // Génération du Window Form
        private void Form1_Load(object sender, EventArgs e)
        {
            generateJson();
            loadJson();
        }

        // Appel au projet Generator pour créer / remplir un JSON
        public void generateJson()
        {
            JsonGenerator dataGenerator = new JsonGenerator();
            dataGenerator.writeJson();
        }

        // Suppression du contenu du JSON 
        public void clearJson()
        {
            String filePath = "../../../../mathador_dataset.json";
            File.WriteAllText(filePath, String.Empty);
        }

        // Génération du JSON pour l'inscrire dans chacun des boutons de l'interface
        // Utilisation du package JSON.NET
        public void loadJson()
        {
            using (StreamReader reader = File.OpenText(@"../../../../mathador_dataset.json"))
            {
                JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                this.targetNumber.Text = (string)o["target"];
                this.number1.Text = (string)o["numbers"][0];
                this.number2.Text = (string)o["numbers"][1];
                this.number3.Text = (string)o["numbers"][2];
                this.number4.Text = (string)o["numbers"][3];
                this.number5.Text = (string)o["numbers"][4];
            }
        }

        // Action lors du clic sur le quatrième chiffre du gamePanel
        // Appel à la fonction toggleSelected
        private void button7_Click(object sender, EventArgs e)
        {
            toggleSelected(this.number4);
        }

        // Action lors du clic sur "Retour" dans le gamePanel
        // Arrêt du jeu et du timer
        private void button1_Click(object sender, EventArgs e)
        {
            // Retour sur le homePanel
            showHomePanel();
        }

        // Action lors du clic sur "Lancer une partie" du homePanel
        // Démarrage de la partie
        private void play_Click(object sender, EventArgs e)
        {
            // Vérification de l'insertion du pseudo avant de lancer une partie
            if (this.inputPseudo.Text != null && this.inputPseudo.Text != "")
            {
                newGame();
                showGamePanel();
            }
            // Sinon, mettre un MessageBox d'erreur
            else
            {
                MessageBox.Show("Merci de saisir un nom d'utilisteur afin de pouvoir commencer la partie !");
            }
        }

        // Action lors du clic sur le tableau
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Action lors du clic sur "Tableau des scores" dans homePanel
        // Affichage du tableau des scores
        private void button2_Click(object sender, EventArgs e)
        {
            showScorePanel();
        }

        // Action lors du clic sur "Retour" dans scorePanel
        // Affichage de l'interface accueil
        private void button3_Click(object sender, EventArgs e)
        {
            showHomePanel();
        }

        // Toggle sur les boutons avec les 4 nombres du Mathador
        private void number1_Click(object sender, EventArgs e)
        {
            toggleSelected(this.number1);
        }

        // Toggle sur les boutons avec les 4 nombres du Mathador
        private void number2_Click(object sender, EventArgs e)
        {
            toggleSelected(this.number2);
        }

        // Toggle sur les boutons avec les 4 nombres du Mathador
        private void number3_Click(object sender, EventArgs e)
        {
            toggleSelected(this.number3);
        }

        // Toggle sur les boutons avec les 4 nombres du Mathador
        private void number5_Click(object sender, EventArgs e)
        {
            toggleSelected(this.number5);
        }

        // Toggle sur les opérateurs du Mathador 
        private void plus_Click(object sender, EventArgs e)
        {
            toggleSelected(this.plus);
        }

        // Toggle sur les opérateurs du Mathador 
        private void minus_Click(object sender, EventArgs e)
        {
            //this.result.Text += " - ";
            toggleSelected(this.minus);
        }

        // Toggle sur les opérateurs du Mathador 
        private void times_Click(object sender, EventArgs e)
        {
            // this.result.Text += " * ";
            toggleSelected(this.times);
        }

        // Toggle sur les opérateurs du Mathador 
        private void divide_Click(object sender, EventArgs e)
        {
            //this.result.Text += " / ";
            toggleSelected(this.divide);
        }

        // Permet de mettre en couleur si le bouton est sélectionné
        public void setSelected(Button sender)
        {
            // listCount[0] = concerne les boutons nombres
            // listCount[1] = concerne les boutons opérateurs

            List<List<Button>> listCount = boardControl();

            // Cas où rien n'est sélectionné
            if (listCount[0].Count == 0 && listCount[1].Count == 0 && sender.Tag.ToString() == "number")
            {
                sender.BackColor = Color.FromName("MenuHighlight");
                operationButtons.Add(sender);
            }
            // Cas où uniquement un chiffre est sélectionné
            else if (listCount[0].Count == 1 && listCount[1].Count == 0 && sender.Tag.ToString() == "operator")
            {
                sender.BackColor = Color.FromName("MenuHighlight");
                operationButtons.Add(sender);
            }
            // Cas où un chiffre et un opérateur sont sélectionnés
            else if (listCount[0].Count == 1 && listCount[1].Count == 1 && sender.Tag.ToString() == "number")
            {
                String operateur = sender.Text;
                sender.BackColor = Color.FromName("MenuHighlight");
                operationButtons.Add(sender);

                foreach (Button button in operationButtons)
                {
                    this.operation += button.Text;
                }
            }

            // Si la list operationButtons est égale à 3, alors le calcul est terminé
            // En effet, deux nombres ont été sélectionné ainsi qu'un opérateur
            if (operationButtons.Count == 3)
            {
                // Appel à la classe GameEngine pour faire les opérations
                // Et récupérer les points selon chaque opération
                GameEngine game = new GameEngine();
                List<int> resultOperation = game.doOperation(operation);

                // Si le résultat retourné est inférieur à 0
                // Alors il y a une erreur dans l'opération : résultat négatif ou à virgule
                // Affichage d'un MessageBox d'erreur
                if (resultOperation[0] < 0)
                {
                    MessageBox.Show("Tu as fait une erreur avec ton calcul. \n Merci de mettre un calcul dont le résultat est un entier positif !", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    // Suppresion de la couleur sur le dernier bouton sélectionné
                    // pour que l'utilisateur puisse choisir un autre nombre
                    operationButtons[2].BackColor = Color.FromName("ControlLight");
                    operationButtons.Remove(operationButtons[2]);
                    this.operation = "";
                }
                else
                {
                    // Création de deux listes :
                    // - list : contient les boutons sélectionnés pendant cette opération
                    // - listValues : contient les valeurs de chaque bouton sélectionné
                    List<Button> list = new List<Button>();
                    List<String> listValues = new List<string>();

                    int index = operationButtonsList.Count - 1;
                    // Pour chaque bouton de la liste de boutons,
                    // on ajoute 
                    foreach (Button b in operationButtons)
                    {
                        list.Add(b);
                        listValues.Add(b.Text);
                    }

                    string currentScore = this.scorePoint.Text;
                    scoreList.Add(currentScore);

                    operationButtonsValuesList.Add(listValues);
                    operationButtonsList.Add(list);
                    operationArray.Add(operation);

                    string operatorValue = operationButtons[1].Text.ToString();
                    if (arrayOperators.IndexOf(operatorValue) == -1)
                    {
                        arrayOperators.Add(operatorValue);
                    }

                    int actualScore = Convert.ToInt32(this.scorePoint.Text);
                    actualScore += resultOperation[1];
                    this.scorePoint.Text = actualScore.ToString();
                    operation = "";

                    operationButtons[2].Text = resultOperation[0].ToString();
                    operationButtons[0].Text = "";
                    operationButtons[0].Enabled = false;

                    operationButtons[0].BackColor = Color.FromName("InactiveCaption");
                    operationButtons[1].BackColor = Color.FromName("ControlLight");
                    operationButtons[2].BackColor = Color.FromName("ControlLight");

                    bool hasWon = false;
                    List<Button> listNumber = new List<Button>();

                    listNumber.Add(this.number1);
                    listNumber.Add(this.number2);
                    listNumber.Add(this.number3);
                    listNumber.Add(this.number4);
                    listNumber.Add(this.number5);

                    foreach (Button button in listNumber)
                    {
                        if (button.Text == this.targetNumber.Text)
                        {
                            hasWon = true;
                        }
                    }

                    // S'il a fait 
                    if (hasWon)
                    {

                        if (arrayOperators.Count == 4)
                        {
                            this.scorePoint.Text = (Convert.ToInt32(this.scorePoint.Text) + 6).ToString();
                        }
                        
                        getNewDataSet();
                    }
                }

                operationButtons.Clear();
            }
        }

        // Toggle qui permet ou non de mettre la couleur sur un bouton
        public void toggleSelected(Button sender)
        {
            if (sender.BackColor == Color.FromName("ControlLight"))
            {
                setSelected(sender);
            }
            else
            {
                removeSelected(sender);
            }
        }

        // Permet de regarder toute l'interface
        // et calculer le nombre de boutons nombre ou opérateurs qui sont colorisés
        public List<List<Button>> boardControl()
        {
            // Définition de trois listes :
            // listNumber = contient les boutons de type nombes 
            // listOperator = contient les boutons de types opérateurs
            // listButton = contient les deux listes précédentes
            List<Button> listNumber = new List<Button>();
            List<Button> listOperator = new List<Button>();
            List<List<Button>> listButton = new List<List<Button>>();

            // Ajout des boutons dans les différentes listes
            listNumber.Add(this.number1);
            listNumber.Add(this.number2);
            listNumber.Add(this.number3);
            listNumber.Add(this.number4);
            listNumber.Add(this.number5);

            listOperator.Add(this.plus);
            listOperator.Add(this.minus);
            listOperator.Add(this.times);
            listOperator.Add(this.divide);

            // On parcourt tous les boutons de type nombres
            // Si le bouton n'a pas une couleur MenuHighlight alors cela signifie qu'il n'est pas sélectionné
            // On le supprimer alors de la liste
            for (int i = listNumber.Count - 1; i >= 0; i--)
            {
                if (listNumber[i].BackColor != Color.FromName("MenuHighlight"))
                {
                    listNumber.RemoveAt(i);
                }
            }

            // On parcourt tous les boutons de type opérateur
            // Si le bouton n'a pas une couleur MenuHighlight alors cela signifie qu'il n'est pas sélectionné
            // On le supprimer alors de la liste
            for (int i = listOperator.Count - 1; i >= 0; i--)
            {
                if (listOperator[i].BackColor != Color.FromName("MenuHighlight"))
                {
                    listOperator.RemoveAt(i);
                }
            }

            // Ajout des deux listes dans la grande liste
            listButton.Add(listNumber);
            listButton.Add(listOperator);

            return listButton;
        }

        // Permet d'enlever la couleur si on clique de nouveau sur un bouton déjà sélectionné
        public void removeSelected(Button sender)
        {
            if (sender.BackColor == Color.FromName("MenuHighlight"))
            {
                operationButtons.Remove(sender);
                sender.BackColor = Color.FromName("ControlLight");
            }
        }

        // Permet de mettre une nouvelle valeur à un bouton
        public void setButtonValue(Button button, int newValue)
        {
            button.Text = newValue.ToString();
        }

        // Sauvegarde en BDD de la partie
        public void saveGame(String pseudo, int score, int time)
        {
            SQLiteCommand sqliteCommand;

            // Connexion à la base de donnée créée précédemment
            SQLiteConnection sqliteConnection = new SQLiteConnection("Data Source=database.sqlite;");
            sqliteConnection.Open();

            // Création de la table game si elle n'existe pas déjà
            sqliteCommand = sqliteConnection.CreateCommand();
            sqliteCommand.CommandText = "CREATE TABLE IF NOT EXISTS game (pseudo varchar(10), score int(2), time int)";
            sqliteCommand.ExecuteNonQuery();

            // Enregistrement de la partie dans la base de donnée
            sqliteCommand.CommandText = "INSERT INTO game VALUES('" + pseudo + "', " + score + ",  " + time + ")";
            sqliteCommand.ExecuteNonQuery();

            // Fermeture de la base de données
            sqliteConnection.Close();

            // Alimentation des données de la base de données dans le tableau des score
            fillDataGridView();
        }

        // Alimentation du tableau des scores selon les données présentes en base de données
        public void fillDataGridView()
        {
            // Connexion à la base de données
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.sqlite");
            conn.Open();

            // Récupération des informations en base
            string query = "SELECT pseudo as Pseudo, score as Score, time as Temps FROM game";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();

            // Liaison des données en bases au tableau des scores
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                this.scoreGridView.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e);
            }

            // Fermeture de la base de données
            conn.Close();

        }

        // Action sur le bouton "Annuler" du gamePanel
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cancel();
        }

        // Action si la textBox pour mettre le pseudo est remplie
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Mettre en visible le scorePanel et les autres panels en invisible
        public void showScorePanel()
        {
            this.homePanel.Visible = false;
            this.gamePanel.Visible = false;
            this.scorePanel.Visible = true;
        }

        // Mettre en visible le homePanel et les autres panels en invisible
        public void showHomePanel()
        {
            this.homePanel.Visible = true;
            this.gamePanel.Visible = false;
            this.scorePanel.Visible = false;
        }

        // Mettre en visible le gamePanel et les autres panels en invisible
        public void showGamePanel()
        {
            this.homePanel.Visible = false;
            this.gamePanel.Visible = true;
            this.scorePanel.Visible = false;
        }

        // Action sur chaque tick du timer
        // 1 tick = 1 seconde
        private void timer_Tick(object sender, EventArgs e)
        {
            // Duration à 180 secondes par défaut
            duration--;
            if (duration > 1) this.timerLabel.Text = duration.ToString() + "s restantes";
            else this.timerLabel.Text = duration.ToString() + "s restante";

            if(duration == 0)
            {
                timer.Stop();

                String user = this.inputPseudo.Text;
                int score = Convert.ToInt32(this.scorePoint.Text);
                int time = 180 - duration;
                saveGame(user, score, time);

                DialogResult dialogResult = MessageBox.Show(
                 "Voulez-vous faire une nouvelle partie ?",                  // the message to show
                 "La partie est terminée !",                    // the title for the dialog box
                 MessageBoxButtons.YesNo,  // show two buttons: Yes and No
                 MessageBoxIcon.Question); // show a question mark icon

                if (dialogResult == DialogResult.Yes)
                {
                    newGame();
                }
                else if (dialogResult == DialogResult.No)
                {
                    operationButtons.Clear();
                    showHomePanel();
                }
            }
        }

        // Action sur "Nouvelle partie" du gamePanel
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            int index = 0;
            if(scoreList.Count > 0)
            {
                foreach (String operation in operationArray)
                {
                    index++;
                }
                this.scorePoint.Text = scoreList[scoreList.Count-index].ToString();

                for (int i = 0; i < index; i++)
                {
                    scoreList.RemoveAt(scoreList.Count-1);
                }
            }

            getNewDataSet();
        }

        // Initialisation des boutons : tout est enable et avec la couleur de base
        public void initButtons()
        {
            this.targetNumber.Enabled = true;
            this.number1.Enabled = true;
            this.number2.Enabled = true;
            this.number3.Enabled = true;
            this.number4.Enabled = true;
            this.number5.Enabled = true;

            this.number1.BackColor = Color.FromName("ControlLight");
            this.number2.BackColor = Color.FromName("ControlLight");
            this.number3.BackColor = Color.FromName("ControlLight");
            this.number4.BackColor = Color.FromName("ControlLight");
            this.number5.BackColor = Color.FromName("ControlLight");
        }
        
        // Permet d'annuler le dernier coup enregistré
        // Deux cas possibles :
        // - aucun bouton n'est selectionné : on réassigne aux derniers boutons modifiés leur valeur avant l'opération
        // - présence d'au moins un bouton sélectionné : on déselectionne les boutons
        public void cancel()
        {
            // On parcourt les boutons pour savoir si il y en a de sélectionnés, et si oui lesquels
            List<List<Button>> board = boardControl();

            int index = operationButtonsList.Count - 1;

            // Si aucun bouton n'est selectionné et qu'il y a déjà eu une opération d'effectuée
            if (board[0].Count == 0 && board[1].Count == 0 && index >= 0)
            {
                // On récupère les infos du coup précédent en faisant une correspondance entre 
                // operationButtonList[index] et operationButtonsValuesList[index]
                // pour le premier nombre sélectionné ( [0] )
                // et pour le deuxième ( [2] )
                operationButtonsList[index][0].Text = operationButtonsValuesList[index][0];
                operationButtonsList[index][2].Text = operationButtonsValuesList[index][2];

                // On remet les deux boutons en enabled
                operationButtonsList[index][0].Enabled = true;
                operationButtonsList[index][2].Enabled = true;

                // On remet le background des deux boutons à leur couleur initiale
                operationButtonsList[index][0].BackColor = Color.FromName("ControlLight");
                operationButtonsList[index][2].BackColor = Color.FromName("ControlLight");

                // On supprime la dernière opération, celle qui vient d'être annulée, dans la liste arrayOperators
                operationArray.RemoveAt(operationArray.Count - 1);

                // On supprime la dernière liste de bouton et leur valeur enregistrées dans operationButtonsList et operationButtonsValuesList
                // operationbuttonsList : contient une liste de boutons (opérateur + deux nombres)
                // operationButtonsValuesList : contient la valeur associées aux boutons
                operationButtonsList.RemoveAt(operationButtonsList.Count - 1);
                operationButtonsValuesList.RemoveAt(operationButtonsValuesList.Count - 1);

                // On récupère le score 
                this.scorePoint.Text = scoreList[index];
                scoreList.RemoveAt(scoreList.Count - 1);

            }
            // Si il y a au moins un bouton sélectionné
            else
            {
                // On récupère les boutons sélectionnés et on les déselectionne
                foreach (Button button in board[0])
                {
                    button.BackColor = Color.FromName("ControlLight");
                }

                foreach (Button button in board[1])
                {
                    button.BackColor = Color.FromName("ControlLight");
                }

                // On vide les éléments présents dans operationsButtons
                operationButtons.Clear();
            }
        }

        public void newGame()
        {
            operationButtons.Clear();
            operationButtonsList.Clear();
            operationArray.Clear();
            operationButtonsValuesList.Clear();
            initButtons();
            clearJson();
            generateJson();
            loadJson();
            duration = 30;
            timer.Enabled = true;
            timer.Start();
            this.scorePoint.Text = Convert.ToString(0);
        }

        public void getNewDataSet()
        {
            operationButtons.Clear();
            operationButtonsList.Clear();
            operationArray.Clear();
            arrayOperators.Clear();
            operationButtonsValuesList.Clear();
            initButtons();
            clearJson();
            generateJson();
            loadJson();
        }
    }
 }