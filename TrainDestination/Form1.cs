namespace TrainDestination
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //種別表示ボタン
        //種別画像を取得してclassificationピクチャボックスに表示
        private void classsf_Click(object sender, EventArgs e)
        {
            if (openclassific.ShowDialog() == DialogResult.OK)
            {
                classification.Load(openclassific.FileName);
            }
        }

        //行先表示ボタン
        //行先画像を取得してclassificationピクチャボックスに表示
        private void dest_Click(object sender, EventArgs e)
        {
            if (opendestination.ShowDialog() == DialogResult.OK)
            {
                destination.Load(opendestination.FileName);
            }
        }

        //帯色変更ボタン
        //最上部の表示色を変更
        private void changeLineColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Line.BackColor = colorDialog1.Color;
            }
        }


        //表示取り消しボタン
        //種別表示・行先表示の画像表示の取り消し
        private void cancel_Click(object sender, EventArgs e)
        {
            classification.Image = null;
            destination.Image = null;
        }

        //閉じるボタン
        //このフォームを閉じる
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
