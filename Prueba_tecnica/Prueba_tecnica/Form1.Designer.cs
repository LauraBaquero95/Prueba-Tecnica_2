namespace Prueba_tecnica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblIngreso = new Label();
            txtNumeros = new TextBox();
            BtnAgregar = new Button();
            BtnOrdenar = new Button();
            label1 = new Label();
            label2 = new Label();
            listNumeros = new ListBox();
            lisOrdenados = new ListBox();
            BtnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(85, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(240, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Numeros Pares e Impares";
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(58, 74);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(92, 15);
            lblIngreso.TabIndex = 1;
            lblIngreso.Text = "Ingresa Numero";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(187, 71);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(44, 23);
            txtNumeros.TabIndex = 2;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = SystemColors.ActiveCaption;
            BtnAgregar.Cursor = Cursors.Hand;
            BtnAgregar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregar.Location = new Point(260, 71);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 3;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnOrdenar
            // 
            BtnOrdenar.BackColor = Color.GreenYellow;
            BtnOrdenar.Cursor = Cursors.Hand;
            BtnOrdenar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnOrdenar.Location = new Point(173, 203);
            BtnOrdenar.Name = "BtnOrdenar";
            BtnOrdenar.Size = new Size(75, 23);
            BtnOrdenar.TabIndex = 4;
            BtnOrdenar.Text = "Ordenar";
            BtnOrdenar.UseVisualStyleBackColor = false;
            BtnOrdenar.Click += BtnOrdenar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 124);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 6;
            label1.Text = "Lista de numeros Creados";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 124);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 8;
            label2.Text = "Numeros Ordenados";
            // 
            // listNumeros
            // 
            listNumeros.FormattingEnabled = true;
            listNumeros.ItemHeight = 15;
            listNumeros.Location = new Point(12, 156);
            listNumeros.Name = "listNumeros";
            listNumeros.Size = new Size(146, 139);
            listNumeros.TabIndex = 9;
            // 
            // lisOrdenados
            // 
            lisOrdenados.FormattingEnabled = true;
            lisOrdenados.ItemHeight = 15;
            lisOrdenados.Location = new Point(260, 156);
            lisOrdenados.Name = "lisOrdenados";
            lisOrdenados.Size = new Size(148, 139);
            lisOrdenados.TabIndex = 10;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.IndianRed;
            BtnLimpiar.Cursor = Cursors.Hand;
            BtnLimpiar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLimpiar.Location = new Point(173, 320);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(75, 23);
            BtnLimpiar.TabIndex = 11;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 355);
            Controls.Add(BtnLimpiar);
            Controls.Add(lisOrdenados);
            Controls.Add(listNumeros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnOrdenar);
            Controls.Add(BtnAgregar);
            Controls.Add(txtNumeros);
            Controls.Add(lblIngreso);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblIngreso;
        private TextBox txtNumeros;
        private Button BtnAgregar;
        private Button BtnOrdenar;
        private Label label1;
        private Label label2;
        private ListBox listNumeros;
        private ListBox lisOrdenados;
        private Button BtnLimpiar;
    }
}
