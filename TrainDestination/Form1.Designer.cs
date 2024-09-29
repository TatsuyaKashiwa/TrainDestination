namespace TrainDestination
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
            tableLayoutPanel1 = new TableLayoutPanel();
            classification = new PictureBox();
            destination = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            close = new Button();
            cancel = new Button();
            button3 = new Button();
            dest = new Button();
            classsf = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)classification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)destination).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(classification, 1, 1);
            tableLayoutPanel1.Controls.Add(destination, 2, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // classification
            // 
            classification.Dock = DockStyle.Fill;
            classification.Location = new Point(43, 48);
            classification.Name = "classification";
            classification.Size = new Size(234, 129);
            classification.TabIndex = 0;
            classification.TabStop = false;
            // 
            // destination
            // 
            destination.Dock = DockStyle.Fill;
            destination.Location = new Point(283, 48);
            destination.Name = "destination";
            destination.Size = new Size(474, 129);
            destination.TabIndex = 1;
            destination.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(close);
            flowLayoutPanel1.Controls.Add(cancel);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(dest);
            flowLayoutPanel1.Controls.Add(classsf);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(43, 408);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(714, 39);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // close
            // 
            close.Location = new Point(618, 3);
            close.Name = "close";
            close.Size = new Size(93, 23);
            close.TabIndex = 0;
            close.Text = "閉じる";
            close.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            cancel.Location = new Point(519, 3);
            cancel.Name = "cancel";
            cancel.Size = new Size(93, 23);
            cancel.TabIndex = 1;
            cancel.Text = "表示取消";
            cancel.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(420, 3);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 2;
            button3.Text = "背景色変更";
            button3.UseVisualStyleBackColor = true;
            // 
            // dest
            // 
            dest.Location = new Point(321, 3);
            dest.Name = "dest";
            dest.Size = new Size(93, 23);
            dest.TabIndex = 3;
            dest.Text = "行先表示";
            dest.UseVisualStyleBackColor = true;
            // 
            // classsf
            // 
            classsf.Location = new Point(222, 3);
            classsf.Name = "classsf";
            classsf.Size = new Size(93, 23);
            classsf.TabIndex = 4;
            classsf.Text = "種別表示";
            classsf.TextImageRelation = TextImageRelation.ImageAboveText;
            classsf.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "列車行先表示";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)classification).EndInit();
            ((System.ComponentModel.ISupportInitialize)destination).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox classification;
        private PictureBox destination;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button close;
        private Button cancel;
        private Button button3;
        private Button dest;
        private Button classsf;
    }
}
