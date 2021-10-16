
namespace CRUB
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
            this.txtFecha = new MetroFramework.Controls.MetroTextBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgPeriodico = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeriodicoID = new MetroFramework.Controls.MetroTextBox();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPeriodico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            // 
            // 
            // 
            this.txtFecha.CustomButton.Image = null;
            this.txtFecha.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtFecha.CustomButton.Name = "";
            this.txtFecha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFecha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFecha.CustomButton.TabIndex = 1;
            this.txtFecha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFecha.CustomButton.UseSelectable = true;
            this.txtFecha.CustomButton.Visible = false;
            this.txtFecha.Lines = new string[0];
            this.txtFecha.Location = new System.Drawing.Point(125, 237);
            this.txtFecha.MaxLength = 32767;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.PasswordChar = '\0';
            this.txtFecha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFecha.SelectedText = "";
            this.txtFecha.SelectionLength = 0;
            this.txtFecha.SelectionStart = 0;
            this.txtFecha.ShortcutsEnabled = true;
            this.txtFecha.Size = new System.Drawing.Size(148, 23);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.UseSelectable = true;
            this.txtFecha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFecha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(125, 143);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(148, 23);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(125, 334);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(148, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(214, 392);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtgPeriodico
            // 
            this.dtgPeriodico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPeriodico.Location = new System.Drawing.Point(335, 52);
            this.dtgPeriodico.Name = "dtgPeriodico";
            this.dtgPeriodico.Size = new System.Drawing.Size(422, 305);
            this.dtgPeriodico.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PeriodicoID";
            // 
            // txtPeriodicoID
            // 
            // 
            // 
            // 
            this.txtPeriodicoID.CustomButton.Image = null;
            this.txtPeriodicoID.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtPeriodicoID.CustomButton.Name = "";
            this.txtPeriodicoID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPeriodicoID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPeriodicoID.CustomButton.TabIndex = 1;
            this.txtPeriodicoID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPeriodicoID.CustomButton.UseSelectable = true;
            this.txtPeriodicoID.CustomButton.Visible = false;
            this.txtPeriodicoID.Lines = new string[0];
            this.txtPeriodicoID.Location = new System.Drawing.Point(125, 52);
            this.txtPeriodicoID.MaxLength = 32767;
            this.txtPeriodicoID.Name = "txtPeriodicoID";
            this.txtPeriodicoID.PasswordChar = '\0';
            this.txtPeriodicoID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPeriodicoID.SelectedText = "";
            this.txtPeriodicoID.SelectionLength = 0;
            this.txtPeriodicoID.SelectionStart = 0;
            this.txtPeriodicoID.ShortcutsEnabled = true;
            this.txtPeriodicoID.Size = new System.Drawing.Size(148, 23);
            this.txtPeriodicoID.TabIndex = 0;
            this.txtPeriodicoID.UseSelectable = true;
            this.txtPeriodicoID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPeriodicoID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(346, 391);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtgPeriodico);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtPeriodicoID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPeriodico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtFecha;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgPeriodico;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtPeriodicoID;
        private MetroFramework.Controls.MetroButton btnEliminar;
    }
}

