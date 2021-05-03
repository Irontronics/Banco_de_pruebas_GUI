
namespace Banco_de_pruebas
{
    partial class Form_inicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chk_bx_motor = new System.Windows.Forms.CheckBox();
            this.chk_bx_genera = new System.Windows.Forms.CheckBox();
            this.groupbx_modos = new System.Windows.Forms.GroupBox();
            this.title_form_initial = new System.Windows.Forms.Label();
            this.picture_Ciateq = new System.Windows.Forms.PictureBox();
            this.Btn_ok_init = new System.Windows.Forms.Button();
            this.btn_cancel_init = new System.Windows.Forms.Button();
            this.COM_init = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupbx_modos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Ciateq)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_bx_motor
            // 
            this.chk_bx_motor.AutoSize = true;
            this.chk_bx_motor.Location = new System.Drawing.Point(15, 24);
            this.chk_bx_motor.Name = "chk_bx_motor";
            this.chk_bx_motor.Size = new System.Drawing.Size(110, 22);
            this.chk_bx_motor.TabIndex = 0;
            this.chk_bx_motor.Text = "Modo Motor";
            this.chk_bx_motor.UseVisualStyleBackColor = true;
            // 
            // chk_bx_genera
            // 
            this.chk_bx_genera.AutoSize = true;
            this.chk_bx_genera.Location = new System.Drawing.Point(15, 52);
            this.chk_bx_genera.Name = "chk_bx_genera";
            this.chk_bx_genera.Size = new System.Drawing.Size(141, 22);
            this.chk_bx_genera.TabIndex = 1;
            this.chk_bx_genera.Text = "Modo Generador";
            this.chk_bx_genera.UseVisualStyleBackColor = true;
            // 
            // groupbx_modos
            // 
            this.groupbx_modos.Controls.Add(this.chk_bx_genera);
            this.groupbx_modos.Controls.Add(this.chk_bx_motor);
            this.groupbx_modos.Enabled = false;
            this.groupbx_modos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbx_modos.Location = new System.Drawing.Point(12, 174);
            this.groupbx_modos.Name = "groupbx_modos";
            this.groupbx_modos.Size = new System.Drawing.Size(271, 101);
            this.groupbx_modos.TabIndex = 2;
            this.groupbx_modos.TabStop = false;
            this.groupbx_modos.Text = "Modos de operación";
            // 
            // title_form_initial
            // 
            this.title_form_initial.AutoSize = true;
            this.title_form_initial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_form_initial.Location = new System.Drawing.Point(51, 18);
            this.title_form_initial.Name = "title_form_initial";
            this.title_form_initial.Size = new System.Drawing.Size(502, 20);
            this.title_form_initial.TabIndex = 3;
            this.title_form_initial.Text = "Banco de pruebas a máquinas eléctricas - CIATEQ ZAPOPAN";
            // 
            // picture_Ciateq
            // 
            this.picture_Ciateq.Image = global::Banco_de_pruebas.Properties.Resources.Capture;
            this.picture_Ciateq.Location = new System.Drawing.Point(214, 46);
            this.picture_Ciateq.Name = "picture_Ciateq";
            this.picture_Ciateq.Size = new System.Drawing.Size(119, 108);
            this.picture_Ciateq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Ciateq.TabIndex = 4;
            this.picture_Ciateq.TabStop = false;
            // 
            // Btn_ok_init
            // 
            this.Btn_ok_init.Enabled = false;
            this.Btn_ok_init.Location = new System.Drawing.Point(477, 316);
            this.Btn_ok_init.Name = "Btn_ok_init";
            this.Btn_ok_init.Size = new System.Drawing.Size(71, 23);
            this.Btn_ok_init.TabIndex = 5;
            this.Btn_ok_init.Text = "OK";
            this.Btn_ok_init.UseVisualStyleBackColor = true;
            // 
            // btn_cancel_init
            // 
            this.btn_cancel_init.Location = new System.Drawing.Point(376, 316);
            this.btn_cancel_init.Name = "btn_cancel_init";
            this.btn_cancel_init.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_init.TabIndex = 6;
            this.btn_cancel_init.Text = "Cancel";
            this.btn_cancel_init.UseVisualStyleBackColor = true;
            this.btn_cancel_init.Click += new System.EventHandler(this.btn_cancel_init_Click);
            // 
            // COM_init
            // 
            this.COM_init.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.COM_init.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COM_init.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.COM_init.Location = new System.Drawing.Point(9, 315);
            this.COM_init.Name = "COM_init";
            this.COM_init.Size = new System.Drawing.Size(38, 21);
            this.COM_init.TabIndex = 7;
            this.COM_init.Text = "COM:";
            this.COM_init.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 315);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM14";
            // 
            // Form_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 345);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.COM_init);
            this.Controls.Add(this.btn_cancel_init);
            this.Controls.Add(this.Btn_ok_init);
            this.Controls.Add(this.picture_Ciateq);
            this.Controls.Add(this.title_form_initial);
            this.Controls.Add(this.groupbx_modos);
            this.Name = "Form_inicial";
            this.Text = "Banco de pruebas CIATEQ ZAPOPAN app";
            this.Load += new System.EventHandler(this.Form_inicial_Load);
            this.groupbx_modos.ResumeLayout(false);
            this.groupbx_modos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Ciateq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_bx_motor;
        private System.Windows.Forms.CheckBox chk_bx_genera;
        private System.Windows.Forms.GroupBox groupbx_modos;
        private System.Windows.Forms.Label title_form_initial;
        private System.Windows.Forms.PictureBox picture_Ciateq;
        private System.Windows.Forms.Button Btn_ok_init;
        private System.Windows.Forms.Button btn_cancel_init;
        private System.Windows.Forms.Label COM_init;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

