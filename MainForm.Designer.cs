namespace MatrixLookup
{
    partial class MainForm
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
            this.sc_form = new System.Windows.Forms.SplitContainer();
            this.gb_matrix_output = new System.Windows.Forms.GroupBox();
            this.gb_matrix_input = new System.Windows.Forms.GroupBox();
            this.gb_operations = new System.Windows.Forms.GroupBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.gb_size = new System.Windows.Forms.GroupBox();
            this.lb_height = new System.Windows.Forms.Label();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.lb_width = new System.Windows.Forms.Label();
            this.tb_width = new System.Windows.Forms.TextBox();
            this.resultOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sc_form)).BeginInit();
            this.sc_form.Panel1.SuspendLayout();
            this.sc_form.Panel2.SuspendLayout();
            this.sc_form.SuspendLayout();
            this.gb_matrix_output.SuspendLayout();
            this.gb_operations.SuspendLayout();
            this.gb_size.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_form
            // 
            this.sc_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_form.IsSplitterFixed = true;
            this.sc_form.Location = new System.Drawing.Point(0, 0);
            this.sc_form.Name = "sc_form";
            // 
            // sc_form.Panel1
            // 
            this.sc_form.Panel1.Controls.Add(this.gb_matrix_output);
            this.sc_form.Panel1.Controls.Add(this.gb_matrix_input);
            // 
            // sc_form.Panel2
            // 
            this.sc_form.Panel2.Controls.Add(this.gb_operations);
            this.sc_form.Panel2.Controls.Add(this.gb_size);
            this.sc_form.Size = new System.Drawing.Size(1075, 668);
            this.sc_form.SplitterDistance = 805;
            this.sc_form.TabIndex = 0;
            // 
            // gb_matrix_output
            // 
            this.gb_matrix_output.Controls.Add(this.resultOutput);
            this.gb_matrix_output.Location = new System.Drawing.Point(4, 259);
            this.gb_matrix_output.Name = "gb_matrix_output";
            this.gb_matrix_output.Size = new System.Drawing.Size(799, 400);
            this.gb_matrix_output.TabIndex = 1;
            this.gb_matrix_output.TabStop = false;
            this.gb_matrix_output.Text = "Результат";
            // 
            // gb_matrix_input
            // 
            this.gb_matrix_input.Location = new System.Drawing.Point(3, 3);
            this.gb_matrix_input.Name = "gb_matrix_input";
            this.gb_matrix_input.Size = new System.Drawing.Size(799, 250);
            this.gb_matrix_input.TabIndex = 0;
            this.gb_matrix_input.TabStop = false;
            this.gb_matrix_input.Text = "Матрица";
            // 
            // gb_operations
            // 
            this.gb_operations.Controls.Add(this.btn_calculate);
            this.gb_operations.Controls.Add(this.btn_random);
            this.gb_operations.Controls.Add(this.btn_open);
            this.gb_operations.Location = new System.Drawing.Point(0, 106);
            this.gb_operations.Name = "gb_operations";
            this.gb_operations.Size = new System.Drawing.Size(266, 559);
            this.gb_operations.TabIndex = 1;
            this.gb_operations.TabStop = false;
            this.gb_operations.Text = "Операции";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(6, 522);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(254, 31);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "Выполнить расчет";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.Btn_calculate_Click);
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(6, 56);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(254, 31);
            this.btn_random.TabIndex = 1;
            this.btn_random.Text = "Заполнить";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.Btn_random_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(6, 19);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(254, 31);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Очистить вывод";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.Btn_clean_output_Click);
            // 
            // gb_size
            // 
            this.gb_size.Controls.Add(this.lb_height);
            this.gb_size.Controls.Add(this.tb_height);
            this.gb_size.Controls.Add(this.lb_width);
            this.gb_size.Controls.Add(this.tb_width);
            this.gb_size.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_size.Location = new System.Drawing.Point(0, 0);
            this.gb_size.Name = "gb_size";
            this.gb_size.Size = new System.Drawing.Size(266, 100);
            this.gb_size.TabIndex = 0;
            this.gb_size.TabStop = false;
            this.gb_size.Text = "Размеры Матрицы";
            // 
            // lb_height
            // 
            this.lb_height.AutoSize = true;
            this.lb_height.Location = new System.Drawing.Point(16, 60);
            this.lb_height.Name = "lb_height";
            this.lb_height.Size = new System.Drawing.Size(51, 13);
            this.lb_height.TabIndex = 3;
            this.lb_height.Text = "Столбцы";
            // 
            // tb_height
            // 
            this.tb_height.Location = new System.Drawing.Point(73, 57);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(179, 20);
            this.tb_height.TabIndex = 2;
            this.tb_height.TextChanged += new System.EventHandler(this.onMatrixHeightChanged);
            // 
            // lb_width
            // 
            this.lb_width.AutoSize = true;
            this.lb_width.Location = new System.Drawing.Point(16, 32);
            this.lb_width.Name = "lb_width";
            this.lb_width.Size = new System.Drawing.Size(43, 13);
            this.lb_width.TabIndex = 1;
            this.lb_width.Text = "Строки";
            // 
            // tb_width
            // 
            this.tb_width.Location = new System.Drawing.Point(73, 29);
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(180, 20);
            this.tb_width.TabIndex = 0;
            this.tb_width.TextChanged += new System.EventHandler(this.onMatrixWidthChanged);
            // 
            // resultOutput
            // 
            this.resultOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultOutput.Location = new System.Drawing.Point(3, 16);
            this.resultOutput.Multiline = true;
            this.resultOutput.Name = "resultOutput";
            this.resultOutput.ReadOnly = true;
            this.resultOutput.Size = new System.Drawing.Size(793, 381);
            this.resultOutput.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 668);
            this.Controls.Add(this.sc_form);
            this.Name = "MainForm";
            this.Text = "Matrix Lookup";
            this.sc_form.Panel1.ResumeLayout(false);
            this.sc_form.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_form)).EndInit();
            this.sc_form.ResumeLayout(false);
            this.gb_matrix_output.ResumeLayout(false);
            this.gb_matrix_output.PerformLayout();
            this.gb_operations.ResumeLayout(false);
            this.gb_size.ResumeLayout(false);
            this.gb_size.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_form;
        private System.Windows.Forms.GroupBox gb_size;
        private System.Windows.Forms.Label lb_height;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.Label lb_width;
        private System.Windows.Forms.TextBox tb_width;
        private System.Windows.Forms.GroupBox gb_operations;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.GroupBox gb_matrix_output;
        private System.Windows.Forms.GroupBox gb_matrix_input;
        private System.Windows.Forms.TextBox resultOutput;
    }
}

