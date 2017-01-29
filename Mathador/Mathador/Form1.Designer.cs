namespace Mathador
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.targetNumber = new System.Windows.Forms.Label();
            this.cibleText = new System.Windows.Forms.Label();
            this.pointsText = new System.Windows.Forms.Label();
            this.scorePoint = new System.Windows.Forms.Label();
            this.buttonGameBack = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.inputPseudo = new System.Windows.Forms.TextBox();
            this.buttonScore = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonScoreBack = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.scoreGridView = new System.Windows.Forms.DataGridView();
            this.homePanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.scorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plus.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(13, 303);
            this.plus.Margin = new System.Windows.Forms.Padding(4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(140, 117);
            this.plus.TabIndex = 0;
            this.plus.Tag = "operator";
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minus.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(201, 303);
            this.minus.Margin = new System.Windows.Forms.Padding(4);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(140, 117);
            this.minus.TabIndex = 1;
            this.minus.Tag = "operator";
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // times
            // 
            this.times.BackColor = System.Drawing.SystemColors.ControlLight;
            this.times.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.times.Location = new System.Drawing.Point(379, 303);
            this.times.Margin = new System.Windows.Forms.Padding(4);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(140, 117);
            this.times.TabIndex = 2;
            this.times.Tag = "operator";
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = false;
            this.times.Click += new System.EventHandler(this.times_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.divide.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(555, 303);
            this.divide.Margin = new System.Windows.Forms.Padding(4);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(140, 117);
            this.divide.TabIndex = 3;
            this.divide.Tag = "operator";
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.number1.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1.Location = new System.Drawing.Point(13, 449);
            this.number1.Margin = new System.Windows.Forms.Padding(4);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(107, 143);
            this.number1.TabIndex = 4;
            this.number1.Tag = "number";
            this.number1.UseVisualStyleBackColor = false;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number5
            // 
            this.number5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.number5.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number5.Location = new System.Drawing.Point(588, 449);
            this.number5.Margin = new System.Windows.Forms.Padding(4);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(107, 143);
            this.number5.TabIndex = 5;
            this.number5.Tag = "number";
            this.number5.UseVisualStyleBackColor = false;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number4
            // 
            this.number4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.number4.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number4.Location = new System.Drawing.Point(452, 449);
            this.number4.Margin = new System.Windows.Forms.Padding(4);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(107, 143);
            this.number4.TabIndex = 6;
            this.number4.Tag = "number";
            this.number4.UseVisualStyleBackColor = false;
            this.number4.Click += new System.EventHandler(this.button7_Click);
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.number3.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number3.Location = new System.Drawing.Point(308, 449);
            this.number3.Margin = new System.Windows.Forms.Padding(4);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(107, 143);
            this.number3.TabIndex = 7;
            this.number3.Tag = "number";
            this.number3.UseVisualStyleBackColor = false;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.number2.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2.Location = new System.Drawing.Point(152, 449);
            this.number2.Margin = new System.Windows.Forms.Padding(4);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(107, 143);
            this.number2.TabIndex = 8;
            this.number2.Tag = "number";
            this.number2.UseVisualStyleBackColor = false;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(281, 671);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 39);
            this.result.TabIndex = 9;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNewGame.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonNewGame.Location = new System.Drawing.Point(13, 766);
            this.buttonNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(271, 47);
            this.buttonNewGame.TabIndex = 10;
            this.buttonNewGame.Text = "Nouvelle partie";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonCancel.Location = new System.Drawing.Point(424, 766);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(271, 47);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // targetNumber
            // 
            this.targetNumber.AutoSize = true;
            this.targetNumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.targetNumber.Font = new System.Drawing.Font("Century Gothic", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.targetNumber.Location = new System.Drawing.Point(289, 135);
            this.targetNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.targetNumber.Name = "targetNumber";
            this.targetNumber.Size = new System.Drawing.Size(0, 99);
            this.targetNumber.TabIndex = 12;
            // 
            // cibleText
            // 
            this.cibleText.AutoSize = true;
            this.cibleText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cibleText.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cibleText.Location = new System.Drawing.Point(313, 86);
            this.cibleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cibleText.Name = "cibleText";
            this.cibleText.Size = new System.Drawing.Size(103, 40);
            this.cibleText.TabIndex = 13;
            this.cibleText.Text = "Cible";
            // 
            // pointsText
            // 
            this.pointsText.AutoSize = true;
            this.pointsText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pointsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pointsText.Location = new System.Drawing.Point(269, 671);
            this.pointsText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pointsText.Name = "pointsText";
            this.pointsText.Size = new System.Drawing.Size(114, 29);
            this.pointsText.TabIndex = 14;
            this.pointsText.Text = "Point(s) :";
            // 
            // scorePoint
            // 
            this.scorePoint.AutoSize = true;
            this.scorePoint.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.scorePoint.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorePoint.Location = new System.Drawing.Point(399, 671);
            this.scorePoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scorePoint.Name = "scorePoint";
            this.scorePoint.Size = new System.Drawing.Size(28, 31);
            this.scorePoint.TabIndex = 15;
            this.scorePoint.Text = "0";
            // 
            // buttonGameBack
            // 
            this.buttonGameBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonGameBack.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonGameBack.Location = new System.Drawing.Point(13, 15);
            this.buttonGameBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGameBack.Name = "buttonGameBack";
            this.buttonGameBack.Size = new System.Drawing.Size(168, 47);
            this.buttonGameBack.TabIndex = 16;
            this.buttonGameBack.Text = "Retour";
            this.buttonGameBack.UseVisualStyleBackColor = false;
            this.buttonGameBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.inputPseudo);
            this.homePanel.Controls.Add(this.buttonScore);
            this.homePanel.Controls.Add(this.buttonPlay);
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Location = new System.Drawing.Point(4, 7);
            this.homePanel.Margin = new System.Windows.Forms.Padding(4);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(728, 826);
            this.homePanel.TabIndex = 17;
            // 
            // inputPseudo
            // 
            this.inputPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputPseudo.Location = new System.Drawing.Point(169, 395);
            this.inputPseudo.Margin = new System.Windows.Forms.Padding(4);
            this.inputPseudo.Name = "inputPseudo";
            this.inputPseudo.Size = new System.Drawing.Size(399, 36);
            this.inputPseudo.TabIndex = 11;
            this.inputPseudo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputPseudo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonScore
            // 
            this.buttonScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonScore.Location = new System.Drawing.Point(192, 577);
            this.buttonScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(353, 58);
            this.buttonScore.TabIndex = 2;
            this.buttonScore.Text = "Tableau des scores";
            this.buttonScore.UseVisualStyleBackColor = true;
            this.buttonScore.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonPlay.Location = new System.Drawing.Point(192, 496);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(353, 58);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Lancer une partie";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(216, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATHADOR";
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.timerLabel);
            this.gamePanel.Controls.Add(this.buttonGameBack);
            this.gamePanel.Controls.Add(this.plus);
            this.gamePanel.Controls.Add(this.minus);
            this.gamePanel.Controls.Add(this.times);
            this.gamePanel.Controls.Add(this.scorePoint);
            this.gamePanel.Controls.Add(this.divide);
            this.gamePanel.Controls.Add(this.pointsText);
            this.gamePanel.Controls.Add(this.number1);
            this.gamePanel.Controls.Add(this.cibleText);
            this.gamePanel.Controls.Add(this.number5);
            this.gamePanel.Controls.Add(this.targetNumber);
            this.gamePanel.Controls.Add(this.number4);
            this.gamePanel.Controls.Add(this.buttonCancel);
            this.gamePanel.Controls.Add(this.number3);
            this.gamePanel.Controls.Add(this.buttonNewGame);
            this.gamePanel.Controls.Add(this.number2);
            this.gamePanel.Controls.Add(this.result);
            this.gamePanel.Location = new System.Drawing.Point(4, 7);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(728, 826);
            this.gamePanel.TabIndex = 19;
            this.gamePanel.Visible = false;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timerLabel.Location = new System.Drawing.Point(524, 15);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(179, 29);
            this.timerLabel.TabIndex = 18;
            this.timerLabel.Text = "180s restantes";
            // 
            // scorePanel
            // 
            this.scorePanel.Controls.Add(this.label2);
            this.scorePanel.Controls.Add(this.buttonScoreBack);
            this.scorePanel.Controls.Add(this.scoreGridView);
            this.scorePanel.Location = new System.Drawing.Point(4, 7);
            this.scorePanel.Margin = new System.Windows.Forms.Padding(4);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(728, 826);
            this.scorePanel.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(201, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tableau des scores";
            // 
            // buttonScoreBack
            // 
            this.buttonScoreBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonScoreBack.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonScoreBack.Location = new System.Drawing.Point(28, 15);
            this.buttonScoreBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonScoreBack.Name = "buttonScoreBack";
            this.buttonScoreBack.Size = new System.Drawing.Size(168, 47);
            this.buttonScoreBack.TabIndex = 17;
            this.buttonScoreBack.Text = "Retour";
            this.buttonScoreBack.UseVisualStyleBackColor = false;
            this.buttonScoreBack.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // scoreGridView
            // 
            this.scoreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreGridView.Location = new System.Drawing.Point(192, 210);
            this.scoreGridView.Margin = new System.Windows.Forms.Padding(4);
            this.scoreGridView.Name = "scoreGridView";
            this.scoreGridView.Size = new System.Drawing.Size(335, 480);
            this.scoreGridView.TabIndex = 0;
            this.scoreGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 846);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.homePanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label targetNumber;
        private System.Windows.Forms.Label cibleText;
        private System.Windows.Forms.Label pointsText;
        private System.Windows.Forms.Label scorePoint;
        private System.Windows.Forms.Button buttonGameBack;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button buttonScore;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.TextBox inputPseudo;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonScoreBack;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridView scoreGridView;
    }
}

