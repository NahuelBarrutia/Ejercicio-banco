namespace VISTA
{
    partial class frmCLIENTES
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
            this.gbCLIENTES = new System.Windows.Forms.GroupBox();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvCLIENTES = new System.Windows.Forms.DataGridView();
            this.gbCLIENTE = new System.Windows.Forms.GroupBox();
            this.txtEDAD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.txtFECHA_NACIMIENTO = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtTELEFONO = new System.Windows.Forms.TextBox();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbCLIENTES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTES)).BeginInit();
            this.gbCLIENTE.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCLIENTES
            // 
            this.gbCLIENTES.Controls.Add(this.btnCERRAR);
            this.gbCLIENTES.Controls.Add(this.btnCONSULTAR);
            this.gbCLIENTES.Controls.Add(this.btnELIMINAR);
            this.gbCLIENTES.Controls.Add(this.btnMODIFICAR);
            this.gbCLIENTES.Controls.Add(this.btnAGREGAR);
            this.gbCLIENTES.Controls.Add(this.dgvCLIENTES);
            this.gbCLIENTES.Location = new System.Drawing.Point(11, 12);
            this.gbCLIENTES.Name = "gbCLIENTES";
            this.gbCLIENTES.Size = new System.Drawing.Size(618, 403);
            this.gbCLIENTES.TabIndex = 0;
            this.gbCLIENTES.TabStop = false;
            this.gbCLIENTES.Text = "Lista de Clientes";
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Location = new System.Drawing.Point(537, 351);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(75, 23);
            this.btnCERRAR.TabIndex = 5;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(249, 351);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(75, 23);
            this.btnCONSULTAR.TabIndex = 4;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(168, 351);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.btnELIMINAR.TabIndex = 3;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(87, 351);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.btnMODIFICAR.TabIndex = 2;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(6, 351);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.btnAGREGAR.TabIndex = 1;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvCLIENTES
            // 
            this.dgvCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCLIENTES.Location = new System.Drawing.Point(1, 35);
            this.dgvCLIENTES.Name = "dgvCLIENTES";
            this.dgvCLIENTES.Size = new System.Drawing.Size(611, 300);
            this.dgvCLIENTES.TabIndex = 0;
            // 
            // gbCLIENTE
            // 
            this.gbCLIENTE.Controls.Add(this.txtEDAD);
            this.gbCLIENTE.Controls.Add(this.label6);
            this.gbCLIENTE.Controls.Add(this.btnCANCELAR);
            this.gbCLIENTE.Controls.Add(this.btnGUARDAR);
            this.gbCLIENTE.Controls.Add(this.txtFECHA_NACIMIENTO);
            this.gbCLIENTE.Controls.Add(this.txtEMAIL);
            this.gbCLIENTE.Controls.Add(this.txtTELEFONO);
            this.gbCLIENTE.Controls.Add(this.txtNOMBRE);
            this.gbCLIENTE.Controls.Add(this.txtDNI);
            this.gbCLIENTE.Controls.Add(this.label5);
            this.gbCLIENTE.Controls.Add(this.label4);
            this.gbCLIENTE.Controls.Add(this.label3);
            this.gbCLIENTE.Controls.Add(this.label2);
            this.gbCLIENTE.Controls.Add(this.label1);
            this.gbCLIENTE.Location = new System.Drawing.Point(635, 12);
            this.gbCLIENTE.Name = "gbCLIENTE";
            this.gbCLIENTE.Size = new System.Drawing.Size(468, 403);
            this.gbCLIENTE.TabIndex = 1;
            this.gbCLIENTE.TabStop = false;
            this.gbCLIENTE.Text = "Datos del Cliente";
            // 
            // txtEDAD
            // 
            this.txtEDAD.Location = new System.Drawing.Point(125, 221);
            this.txtEDAD.Name = "txtEDAD";
            this.txtEDAD.ReadOnly = true;
            this.txtEDAD.Size = new System.Drawing.Size(202, 20);
            this.txtEDAD.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Edad:";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(376, 365);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(75, 23);
            this.btnCANCELAR.TabIndex = 11;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(26, 365);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(75, 23);
            this.btnGUARDAR.TabIndex = 10;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // txtFECHA_NACIMIENTO
            // 
            this.txtFECHA_NACIMIENTO.Location = new System.Drawing.Point(125, 176);
            this.txtFECHA_NACIMIENTO.Name = "txtFECHA_NACIMIENTO";
            this.txtFECHA_NACIMIENTO.Size = new System.Drawing.Size(202, 20);
            this.txtFECHA_NACIMIENTO.TabIndex = 9;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(125, 140);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(202, 20);
            this.txtEMAIL.TabIndex = 8;
            // 
            // txtTELEFONO
            // 
            this.txtTELEFONO.Location = new System.Drawing.Point(125, 103);
            this.txtTELEFONO.Name = "txtTELEFONO";
            this.txtTELEFONO.Size = new System.Drawing.Size(202, 20);
            this.txtTELEFONO.TabIndex = 7;
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(125, 67);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(202, 20);
            this.txtNOMBRE.TabIndex = 6;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(125, 35);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(105, 20);
            this.txtDNI.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // frmCLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 450);
            this.Controls.Add(this.gbCLIENTE);
            this.Controls.Add(this.gbCLIENTES);
            this.Name = "frmCLIENTES";
            this.Text = "::.. CLIENTES DEL BANCO";
            this.gbCLIENTES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTES)).EndInit();
            this.gbCLIENTE.ResumeLayout(false);
            this.gbCLIENTE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCLIENTES;
        private System.Windows.Forms.GroupBox gbCLIENTE;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvCLIENTES;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TextBox txtFECHA_NACIMIENTO;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtTELEFONO;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEDAD;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

