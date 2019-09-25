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
            this.SuspendLayout();
            // 
            // calculateChain
            // 
            this.calculateChain.Location = new System.Drawing.Point(12, 43);
            this.calculateChain.Name = "calculateChain";
            this.calculateChain.Size = new System.Drawing.Size(98, 22);
            this.calculateChain.TabIndex = 0;
            this.calculateChain.Text = "Cargar Datos";
            this.calculateChain.UseVisualStyleBackColor = true;
            this.calculateChain.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SaveDates
            // 
            this.SaveDates.Location = new System.Drawing.Point(12, 88);
            this.SaveDates.Name = "SaveDates";
            this.SaveDates.Size = new System.Drawing.Size(98, 23);
            this.SaveDates.TabIndex = 1;
            this.SaveDates.Text = "Guardar Datos";
            this.SaveDates.UseVisualStyleBackColor = true;
            this.SaveDates.Click += new System.EventHandler(this.SaveDates_Click);
            // 
            // lastState
            // 
            this.lastState.FormattingEnabled = true;
            this.lastState.Location = new System.Drawing.Point(265, 43);
            this.lastState.Name = "lastState";
            this.lastState.Size = new System.Drawing.Size(156, 21);
            this.lastState.TabIndex = 2;
            this.lastState.SelectedIndexChanged += new System.EventHandler(this.lastState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ESTADO ANTERIOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ESTADO SIGUIENTE";
            // 
            // NextState
            // 
            this.NextState.BackColor = System.Drawing.SystemColors.Window;
            this.NextState.FormattingEnabled = true;
            this.NextState.Location = new System.Drawing.Point(504, 43);
            this.NextState.Name = "NextState";
            this.NextState.Size = new System.Drawing.Size(156, 21);
            this.NextState.TabIndex = 5;
            // 
            // dayAnalyze
            // 
            this.dayAnalyze.Location = new System.Drawing.Point(265, 105);
            this.dayAnalyze.Name = "dayAnalyze";
            this.dayAnalyze.Size = new System.Drawing.Size(156, 20);
            this.dayAnalyze.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DIAS A ANALIZAR";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(504, 104);
            this.Result.Name = "Result";
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Result.Size = new System.Drawing.Size(156, 20);
            this.Result.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "RESULTADO";
            // 
            // getResult
            // 
            this.getResult.Location = new System.Drawing.Point(13, 133);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(97, 23);
            this.getResult.TabIndex = 10;
            this.getResult.Text = "Dar Resultado";
            this.getResult.UseVisualStyleBackColor = true;
            this.getResult.Click += new System.EventHandler(this.getResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

