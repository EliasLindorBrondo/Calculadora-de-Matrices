
namespace Calculadora_de_Matrices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCrearmB = new System.Windows.Forms.Button();
            this.btnres = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.btnCrearmA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.escalarB = new System.Windows.Forms.TextBox();
            this.btnEscalarA = new System.Windows.Forms.Button();
            this.escalarA = new System.Windows.Forms.TextBox();
            this.btnOpuestaRes = new System.Windows.Forms.Button();
            this.btnTraspuestaRes = new System.Windows.Forms.Button();
            this.btnTraspuestaB = new System.Windows.Forms.Button();
            this.btnTraspuestaA = new System.Windows.Forms.Button();
            this.btnOpuestaB = new System.Windows.Forms.Button();
            this.btnopuestaA = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxMatrizResultante = new System.Windows.Forms.GroupBox();
            this.groupBoxMatriz2 = new System.Windows.Forms.GroupBox();
            this.groupBoxMatriz1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearmB
            // 
            this.btnCrearmB.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCrearmB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearmB.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearmB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearmB.Location = new System.Drawing.Point(619, 76);
            this.btnCrearmB.Name = "btnCrearmB";
            this.btnCrearmB.Size = new System.Drawing.Size(113, 26);
            this.btnCrearmB.TabIndex = 31;
            this.btnCrearmB.Text = "Crear Matriz";
            this.btnCrearmB.UseVisualStyleBackColor = false;
            this.btnCrearmB.Click += new System.EventHandler(this.btnCrearmB_Click_1);
            // 
            // btnres
            // 
            this.btnres.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnres.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnres.Location = new System.Drawing.Point(385, 7);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(119, 35);
            this.btnres.TabIndex = 30;
            this.btnres.Text = "Restar A - B";
            this.btnres.UseVisualStyleBackColor = false;
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnmult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnmult.Location = new System.Drawing.Point(704, 7);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(130, 35);
            this.btnmult.TabIndex = 29;
            this.btnmult.Text = "Multiplicar AxB";
            this.btnmult.UseVisualStyleBackColor = false;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btnsum
            // 
            this.btnsum.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnsum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsum.Location = new System.Drawing.Point(84, 7);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(112, 40);
            this.btnsum.TabIndex = 28;
            this.btnsum.Text = "Sumar A + B";
            this.btnsum.UseVisualStyleBackColor = false;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btnCrearmA
            // 
            this.btnCrearmA.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCrearmA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearmA.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearmA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearmA.Location = new System.Drawing.Point(619, 23);
            this.btnCrearmA.Name = "btnCrearmA";
            this.btnCrearmA.Size = new System.Drawing.Size(113, 26);
            this.btnCrearmA.TabIndex = 27;
            this.btnCrearmA.Text = "Crear Matriz";
            this.btnCrearmA.UseVisualStyleBackColor = false;
            this.btnCrearmA.Click += new System.EventHandler(this.btnCrearmA_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(490, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "x";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(523, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 20);
            this.textBox4.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(523, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 20);
            this.textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(444, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(444, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(318, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Matriz B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(318, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Matriz A";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnsum);
            this.groupBox1.Controls.Add(this.btnres);
            this.groupBox1.Controls.Add(this.escalarB);
            this.groupBox1.Controls.Add(this.btnmult);
            this.groupBox1.Controls.Add(this.btnEscalarA);
            this.groupBox1.Controls.Add(this.escalarA);
            this.groupBox1.Controls.Add(this.btnOpuestaRes);
            this.groupBox1.Controls.Add(this.btnTraspuestaRes);
            this.groupBox1.Controls.Add(this.btnTraspuestaB);
            this.groupBox1.Controls.Add(this.btnTraspuestaA);
            this.groupBox1.Controls.Add(this.btnOpuestaB);
            this.groupBox1.Controls.Add(this.btnopuestaA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBoxMatrizResultante);
            this.groupBox1.Controls.Add(this.groupBoxMatriz2);
            this.groupBox1.Controls.Add(this.groupBoxMatriz1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(31, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 523);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightYellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(385, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Multiplicar Por";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnEscalarB_Click);
            // 
            // escalarB
            // 
            this.escalarB.Location = new System.Drawing.Point(494, 352);
            this.escalarB.Name = "escalarB";
            this.escalarB.Size = new System.Drawing.Size(38, 20);
            this.escalarB.TabIndex = 25;
            // 
            // btnEscalarA
            // 
            this.btnEscalarA.BackColor = System.Drawing.Color.LightYellow;
            this.btnEscalarA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEscalarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscalarA.Location = new System.Drawing.Point(51, 347);
            this.btnEscalarA.Name = "btnEscalarA";
            this.btnEscalarA.Size = new System.Drawing.Size(101, 28);
            this.btnEscalarA.TabIndex = 24;
            this.btnEscalarA.Text = "Multiplicar Por";
            this.btnEscalarA.UseVisualStyleBackColor = false;
            this.btnEscalarA.Click += new System.EventHandler(this.btnEscalarA_Click);
            // 
            // escalarA
            // 
            this.escalarA.Location = new System.Drawing.Point(170, 352);
            this.escalarA.Name = "escalarA";
            this.escalarA.Size = new System.Drawing.Size(38, 20);
            this.escalarA.TabIndex = 23;
            // 
            // btnOpuestaRes
            // 
            this.btnOpuestaRes.BackColor = System.Drawing.Color.LightYellow;
            this.btnOpuestaRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpuestaRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpuestaRes.Location = new System.Drawing.Point(714, 347);
            this.btnOpuestaRes.Name = "btnOpuestaRes";
            this.btnOpuestaRes.Size = new System.Drawing.Size(101, 23);
            this.btnOpuestaRes.TabIndex = 22;
            this.btnOpuestaRes.Text = "Opuesta";
            this.btnOpuestaRes.UseVisualStyleBackColor = false;
            this.btnOpuestaRes.Click += new System.EventHandler(this.btnOpuestaRes_Click);
            // 
            // btnTraspuestaRes
            // 
            this.btnTraspuestaRes.BackColor = System.Drawing.Color.LightYellow;
            this.btnTraspuestaRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraspuestaRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraspuestaRes.Location = new System.Drawing.Point(714, 392);
            this.btnTraspuestaRes.Name = "btnTraspuestaRes";
            this.btnTraspuestaRes.Size = new System.Drawing.Size(101, 23);
            this.btnTraspuestaRes.TabIndex = 15;
            this.btnTraspuestaRes.Text = "Traspuesta";
            this.btnTraspuestaRes.UseVisualStyleBackColor = false;
            this.btnTraspuestaRes.Click += new System.EventHandler(this.btnTraspuestaRes_Click);
            // 
            // btnTraspuestaB
            // 
            this.btnTraspuestaB.BackColor = System.Drawing.Color.LightYellow;
            this.btnTraspuestaB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraspuestaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraspuestaB.Location = new System.Drawing.Point(385, 430);
            this.btnTraspuestaB.Name = "btnTraspuestaB";
            this.btnTraspuestaB.Size = new System.Drawing.Size(101, 23);
            this.btnTraspuestaB.TabIndex = 21;
            this.btnTraspuestaB.Text = "Traspuesta";
            this.btnTraspuestaB.UseVisualStyleBackColor = false;
            this.btnTraspuestaB.Click += new System.EventHandler(this.btnTraspuestaB_Click);
            // 
            // btnTraspuestaA
            // 
            this.btnTraspuestaA.BackColor = System.Drawing.Color.LightYellow;
            this.btnTraspuestaA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraspuestaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraspuestaA.Location = new System.Drawing.Point(51, 430);
            this.btnTraspuestaA.Name = "btnTraspuestaA";
            this.btnTraspuestaA.Size = new System.Drawing.Size(101, 23);
            this.btnTraspuestaA.TabIndex = 18;
            this.btnTraspuestaA.Text = "Traspuesta";
            this.btnTraspuestaA.UseVisualStyleBackColor = false;
            this.btnTraspuestaA.Click += new System.EventHandler(this.btnTraspuestaA_Click);
            // 
            // btnOpuestaB
            // 
            this.btnOpuestaB.BackColor = System.Drawing.Color.LightYellow;
            this.btnOpuestaB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpuestaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpuestaB.Location = new System.Drawing.Point(385, 392);
            this.btnOpuestaB.Name = "btnOpuestaB";
            this.btnOpuestaB.Size = new System.Drawing.Size(101, 23);
            this.btnOpuestaB.TabIndex = 20;
            this.btnOpuestaB.Text = "Opuesta";
            this.btnOpuestaB.UseVisualStyleBackColor = false;
            this.btnOpuestaB.Click += new System.EventHandler(this.btnOpuestaB_Click);
            // 
            // btnopuestaA
            // 
            this.btnopuestaA.BackColor = System.Drawing.Color.LightYellow;
            this.btnopuestaA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnopuestaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopuestaA.Location = new System.Drawing.Point(51, 392);
            this.btnopuestaA.Name = "btnopuestaA";
            this.btnopuestaA.Size = new System.Drawing.Size(101, 23);
            this.btnopuestaA.TabIndex = 18;
            this.btnopuestaA.Text = "Opuesta";
            this.btnopuestaA.UseVisualStyleBackColor = false;
            this.btnopuestaA.Click += new System.EventHandler(this.btnopuestaA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(582, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "=";
            // 
            // groupBoxMatrizResultante
            // 
            this.groupBoxMatrizResultante.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMatrizResultante.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxMatrizResultante.Location = new System.Drawing.Point(619, 48);
            this.groupBoxMatrizResultante.Name = "groupBoxMatrizResultante";
            this.groupBoxMatrizResultante.Size = new System.Drawing.Size(305, 278);
            this.groupBoxMatrizResultante.TabIndex = 2;
            this.groupBoxMatrizResultante.TabStop = false;
            this.groupBoxMatrizResultante.Text = "Matriz Resultado";
            // 
            // groupBoxMatriz2
            // 
            this.groupBoxMatriz2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMatriz2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxMatriz2.Location = new System.Drawing.Point(300, 48);
            this.groupBoxMatriz2.Name = "groupBoxMatriz2";
            this.groupBoxMatriz2.Size = new System.Drawing.Size(276, 278);
            this.groupBoxMatriz2.TabIndex = 1;
            this.groupBoxMatriz2.TabStop = false;
            this.groupBoxMatriz2.Text = "Matriz B";
            // 
            // groupBoxMatriz1
            // 
            this.groupBoxMatriz1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMatriz1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxMatriz1.Location = new System.Drawing.Point(6, 48);
            this.groupBoxMatriz1.Name = "groupBoxMatriz1";
            this.groupBoxMatriz1.Size = new System.Drawing.Size(278, 278);
            this.groupBoxMatriz1.TabIndex = 0;
            this.groupBoxMatriz1.TabStop = false;
            this.groupBoxMatriz1.Text = "Matriz A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(490, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(981, 649);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCrearmB);
            this.Controls.Add(this.btnCrearmA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearmB;
        private System.Windows.Forms.Button btnres;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnCrearmA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTraspuestaRes;
        private System.Windows.Forms.Button btnTraspuestaB;
        private System.Windows.Forms.Button btnTraspuestaA;
        private System.Windows.Forms.Button btnOpuestaB;
        private System.Windows.Forms.Button btnopuestaA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxMatrizResultante;
        private System.Windows.Forms.GroupBox groupBoxMatriz2;
        private System.Windows.Forms.GroupBox groupBoxMatriz1;
        private System.Windows.Forms.Button btnOpuestaRes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox escalarB;
        private System.Windows.Forms.Button btnEscalarA;
        private System.Windows.Forms.TextBox escalarA;
        private System.Windows.Forms.Label label4;
    }
}

