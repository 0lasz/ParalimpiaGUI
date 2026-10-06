namespace ParalimpiaGUI
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
            label1 = new Label();
            lb_szur = new TextBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Orszag = new DataGridViewTextBoxColumn();
            Varos = new DataGridViewTextBoxColumn();
            Ev = new DataGridViewTextBoxColumn();
            Arany = new DataGridViewTextBoxColumn();
            Ezust = new DataGridViewTextBoxColumn();
            Bronz = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lb_ev = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_arany = new TextBox();
            tb_ezust = new TextBox();
            tb_bronz = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(31, 50);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 0;
            label1.Text = "Szűrés ország vagy város alapján";
            // 
            // lb_szur
            // 
            lb_szur.Location = new Point(378, 51);
            lb_szur.Name = "lb_szur";
            lb_szur.Size = new Size(339, 23);
            lb_szur.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Orszag, Varos, Ev, Arany, Ezust, Bronz });
            dataGridView1.Location = new Point(33, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(733, 238);
            dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            Id.HeaderText = "#";
            Id.Name = "Id";
            // 
            // Orszag
            // 
            Orszag.HeaderText = "rendező ország";
            Orszag.Name = "Orszag";
            // 
            // Varos
            // 
            Varos.HeaderText = "helyszín";
            Varos.Name = "Varos";
            // 
            // Ev
            // 
            Ev.HeaderText = "év";
            Ev.Name = "Ev";
            // 
            // Arany
            // 
            Arany.HeaderText = "arany";
            Arany.Name = "Arany";
            // 
            // Ezust
            // 
            Ezust.HeaderText = "ezust";
            Ezust.Name = "Ezust";
            // 
            // Bronz
            // 
            Bronz.HeaderText = "bronz";
            Bronz.Name = "Bronz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 388);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "kijelölt év:";
            // 
            // lb_ev
            // 
            lb_ev.AutoSize = true;
            lb_ev.Location = new Point(184, 388);
            lb_ev.Name = "lb_ev";
            lb_ev.Size = new Size(35, 15);
            lb_ev.TabIndex = 4;
            lb_ev.Text = "####";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(282, 365);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "arany";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(378, 365);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 6;
            label4.Text = "ezüst";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(478, 367);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 7;
            label5.Text = "bronz";
            // 
            // tb_arany
            // 
            tb_arany.Location = new Point(282, 385);
            tb_arany.Name = "tb_arany";
            tb_arany.Size = new Size(21, 23);
            tb_arany.TabIndex = 8;
            // 
            // tb_ezust
            // 
            tb_ezust.Location = new Point(378, 385);
            tb_ezust.Name = "tb_ezust";
            tb_ezust.Size = new Size(22, 23);
            tb_ezust.TabIndex = 9;
            // 
            // tb_bronz
            // 
            tb_bronz.Location = new Point(478, 385);
            tb_bronz.Name = "tb_bronz";
            tb_bronz.Size = new Size(22, 23);
            tb_bronz.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(586, 385);
            button1.Name = "button1";
            button1.Size = new Size(180, 53);
            button1.TabIndex = 11;
            button1.Text = "módosítási javaslat";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tb_bronz);
            Controls.Add(tb_ezust);
            Controls.Add(tb_arany);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lb_ev);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(lb_szur);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Magyar Paralimpia Eredmények";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox lb_szur;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Orszag;
        private DataGridViewTextBoxColumn Varos;
        private DataGridViewTextBoxColumn Ev;
        private DataGridViewTextBoxColumn Arany;
        private DataGridViewTextBoxColumn Ezust;
        private DataGridViewTextBoxColumn Bronz;
        private Label label2;
        private Label lb_ev;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_arany;
        private TextBox tb_ezust;
        private TextBox tb_bronz;
        private Button button1;
    }
}
