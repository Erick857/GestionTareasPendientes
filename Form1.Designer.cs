namespace GestionTareasPendientes
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
            this.lst_Tareas = new System.Windows.Forms.ListBox();
            this.btn_AgregarTarea = new System.Windows.Forms.Button();
            this.btn_EliminarTarea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Tarea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_Tareas
            // 
            this.lst_Tareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Tareas.FormattingEnabled = true;
            this.lst_Tareas.ItemHeight = 20;
            this.lst_Tareas.Location = new System.Drawing.Point(320, 181);
            this.lst_Tareas.Name = "lst_Tareas";
            this.lst_Tareas.Size = new System.Drawing.Size(403, 384);
            this.lst_Tareas.TabIndex = 0;
            // 
            // btn_AgregarTarea
            // 
            this.btn_AgregarTarea.Location = new System.Drawing.Point(320, 588);
            this.btn_AgregarTarea.Name = "btn_AgregarTarea";
            this.btn_AgregarTarea.Size = new System.Drawing.Size(109, 48);
            this.btn_AgregarTarea.TabIndex = 1;
            this.btn_AgregarTarea.Text = "Agregar Tarea";
            this.btn_AgregarTarea.UseVisualStyleBackColor = true;
            this.btn_AgregarTarea.Click += new System.EventHandler(this.btn_AgregarTarea_Click);
            // 
            // btn_EliminarTarea
            // 
            this.btn_EliminarTarea.Location = new System.Drawing.Point(461, 588);
            this.btn_EliminarTarea.Name = "btn_EliminarTarea";
            this.btn_EliminarTarea.Size = new System.Drawing.Size(109, 48);
            this.btn_EliminarTarea.TabIndex = 2;
            this.btn_EliminarTarea.Text = "Eliminar Tarea";
            this.btn_EliminarTarea.UseVisualStyleBackColor = true;
            this.btn_EliminarTarea.Click += new System.EventHandler(this.btn_EliminarTarea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresos de Tareas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Tarea
            // 
            this.txt_Tarea.Location = new System.Drawing.Point(320, 142);
            this.txt_Tarea.Name = "txt_Tarea";
            this.txt_Tarea.Size = new System.Drawing.Size(221, 23);
            this.txt_Tarea.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 776);
            this.Controls.Add(this.txt_Tarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_EliminarTarea);
            this.Controls.Add(this.btn_AgregarTarea);
            this.Controls.Add(this.lst_Tareas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Tareas;
        private System.Windows.Forms.Button btn_AgregarTarea;
        private System.Windows.Forms.Button btn_EliminarTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Tarea;
    }
}

