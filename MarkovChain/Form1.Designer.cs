namespace MarkovChain
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateChain = new System.Windows.Forms.Button();
            this.SaveDates = new System.Windows.Forms.Button();
            this.lastState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NextState = new System.Windows.Forms.ComboBox();
            this.dayAnalyze = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.getResult = new System.Windows.Forms.Button();
            this.probLimits = new System.Windows.Forms.ComboBox();
            this.ProbabilityLimits = new System.Windows.Forms.TextBox();
            this.getProbLimit = new System.Windows.Forms.Button();
            this.returnTime = new System.Windows.Forms.Button();
            this.returnTimeSelect = new System.Windows.Forms.ComboBox();
            this.returnSelectTime = new System.Windows.Forms.TextBox();
            this.Probabilities = new System.Windows.Forms.Button();
            this.stateProm = new System.Windows.Forms.ComboBox();
            this.combinatoryItems = new System.Windows.Forms.ComboBox();
            this.resultProm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateChain
            // 
            this.calculateChain.Location = new System.Drawing.Point(12, 78);
            this.calculateChain.Name = "calculateChain";
            this.calculateChain.Size = new System.Drawing.Size(111, 22);
            this.calculateChain.TabIndex = 0;
            this.calculateChain.Text = "Cargar Datos";
            this.calculateChain.UseVisualStyleBackColor = true;
            this.calculateChain.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SaveDates
            // 
            this.SaveDates.Location = new System.Drawing.Point(476, 353);
            this.SaveDates.Name = "SaveDates";
            this.SaveDates.Size = new System.Drawing.Size(110, 23);
            this.SaveDates.TabIndex = 1;
            this.SaveDates.Text = "Guardar Datos";
            this.SaveDates.UseVisualStyleBackColor = true;
            this.SaveDates.Click += new System.EventHandler(this.SaveDates_Click);
            // 
            // lastState
            // 
            this.lastState.FormattingEnabled = true;
            this.lastState.Location = new System.Drawing.Point(167, 80);
            this.lastState.Name = "lastState";
            this.lastState.Size = new System.Drawing.Size(156, 21);
            this.lastState.TabIndex = 2;
            this.lastState.SelectedIndexChanged += new System.EventHandler(this.lastState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ESTADO ANTERIOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ESTADO SIGUIENTE";
            // 
            // NextState
            // 
            this.NextState.BackColor = System.Drawing.SystemColors.Window;
            this.NextState.FormattingEnabled = true;
            this.NextState.Location = new System.Drawing.Point(430, 78);
            this.NextState.Name = "NextState";
            this.NextState.Size = new System.Drawing.Size(156, 21);
            this.NextState.TabIndex = 5;
            // 
            // dayAnalyze
            // 
            this.dayAnalyze.Location = new System.Drawing.Point(167, 138);
            this.dayAnalyze.Name = "dayAnalyze";
            this.dayAnalyze.Size = new System.Drawing.Size(156, 20);
            this.dayAnalyze.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DIAS A ANALIZAR";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(430, 137);
            this.Result.Name = "Result";
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Result.Size = new System.Drawing.Size(156, 20);
            this.Result.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "RESULTADO";
            // 
            // getResult
            // 
            this.getResult.Location = new System.Drawing.Point(12, 135);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(110, 23);
            this.getResult.TabIndex = 10;
            this.getResult.Text = "Dar Resultado";
            this.getResult.UseVisualStyleBackColor = true;
            this.getResult.Click += new System.EventHandler(this.getResult_Click);
            // 
            // probLimits
            // 
            this.probLimits.FormattingEnabled = true;
            this.probLimits.Location = new System.Drawing.Point(167, 192);
            this.probLimits.Name = "probLimits";
            this.probLimits.Size = new System.Drawing.Size(156, 21);
            this.probLimits.TabIndex = 11;
            // 
            // ProbabilityLimits
            // 
            this.ProbabilityLimits.Location = new System.Drawing.Point(430, 195);
            this.ProbabilityLimits.Name = "ProbabilityLimits";
            this.ProbabilityLimits.Size = new System.Drawing.Size(156, 20);
            this.ProbabilityLimits.TabIndex = 12;
            // 
            // getProbLimit
            // 
            this.getProbLimit.Location = new System.Drawing.Point(12, 192);
            this.getProbLimit.Name = "getProbLimit";
            this.getProbLimit.Size = new System.Drawing.Size(108, 23);
            this.getProbLimit.TabIndex = 13;
            this.getProbLimit.Text = "Probabilidad limite";
            this.getProbLimit.UseVisualStyleBackColor = true;
            this.getProbLimit.Click += new System.EventHandler(this.getProbLimit_Click);
            // 
            // returnTime
            // 
            this.returnTime.Location = new System.Drawing.Point(14, 239);
            this.returnTime.Name = "returnTime";
            this.returnTime.Size = new System.Drawing.Size(108, 23);
            this.returnTime.TabIndex = 14;
            this.returnTime.Text = "Tiempo de retorno";
            this.returnTime.UseVisualStyleBackColor = true;
            this.returnTime.Click += new System.EventHandler(this.returnTime_Click);
            // 
            // returnTimeSelect
            // 
            this.returnTimeSelect.FormattingEnabled = true;
            this.returnTimeSelect.Location = new System.Drawing.Point(167, 239);
            this.returnTimeSelect.Name = "returnTimeSelect";
            this.returnTimeSelect.Size = new System.Drawing.Size(156, 21);
            this.returnTimeSelect.TabIndex = 15;
            // 
            // returnSelectTime
            // 
            this.returnSelectTime.Location = new System.Drawing.Point(430, 242);
            this.returnSelectTime.Name = "returnSelectTime";
            this.returnSelectTime.Size = new System.Drawing.Size(156, 20);
            this.returnSelectTime.TabIndex = 16;
            this.returnSelectTime.TextChanged += new System.EventHandler(this.returnSelectTime_TextChanged);
            // 
            // Probabilities
            // 
            this.Probabilities.Location = new System.Drawing.Point(14, 297);
            this.Probabilities.Name = "Probabilities";
            this.Probabilities.Size = new System.Drawing.Size(110, 23);
            this.Probabilities.TabIndex = 17;
            this.Probabilities.Text = "Probabilidades";
            this.Probabilities.UseVisualStyleBackColor = true;
            this.Probabilities.Click += new System.EventHandler(this.Probabilities_Click);
            // 
            // stateProm
            // 
            this.stateProm.FormattingEnabled = true;
            this.stateProm.Location = new System.Drawing.Point(167, 299);
            this.stateProm.Name = "stateProm";
            this.stateProm.Size = new System.Drawing.Size(110, 21);
            this.stateProm.TabIndex = 18;
            this.stateProm.SelectedIndexChanged += new System.EventHandler(this.StateProm_SelectedIndexChanged);
            // 
            // combinatoryItems
            // 
            this.combinatoryItems.FormattingEnabled = true;
            this.combinatoryItems.Location = new System.Drawing.Point(301, 299);
            this.combinatoryItems.Name = "combinatoryItems";
            this.combinatoryItems.Size = new System.Drawing.Size(110, 21);
            this.combinatoryItems.TabIndex = 19;
            // 
            // resultProm
            // 
            this.resultProm.Location = new System.Drawing.Point(430, 300);
            this.resultProm.Name = "resultProm";
            this.resultProm.Size = new System.Drawing.Size(156, 20);
            this.resultProm.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "ESTADOS";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "PROBABILIDAD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "ESTADOS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(443, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "TIEMPO DE RETORNO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(189, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "ESTADOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(617, 392);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultProm);
            this.Controls.Add(this.combinatoryItems);
            this.Controls.Add(this.stateProm);
            this.Controls.Add(this.Probabilities);
            this.Controls.Add(this.returnSelectTime);
            this.Controls.Add(this.returnTimeSelect);
            this.Controls.Add(this.returnTime);
            this.Controls.Add(this.getProbLimit);
            this.Controls.Add(this.ProbabilityLimits);
            this.Controls.Add(this.probLimits);
            this.Controls.Add(this.getResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dayAnalyze);
            this.Controls.Add(this.NextState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastState);
            this.Controls.Add(this.SaveDates);
            this.Controls.Add(this.calculateChain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateChain;
        private System.Windows.Forms.Button SaveDates;
        private System.Windows.Forms.ComboBox lastState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NextState;
        private System.Windows.Forms.TextBox dayAnalyze;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getResult;
        private System.Windows.Forms.ComboBox probLimits;
        private System.Windows.Forms.TextBox ProbabilityLimits;
        private System.Windows.Forms.Button getProbLimit;
        private System.Windows.Forms.Button returnTime;
        private System.Windows.Forms.ComboBox returnTimeSelect;
        private System.Windows.Forms.TextBox returnSelectTime;
        private System.Windows.Forms.Button Probabilities;
        private System.Windows.Forms.ComboBox stateProm;
        private System.Windows.Forms.ComboBox combinatoryItems;
        private System.Windows.Forms.TextBox resultProm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

