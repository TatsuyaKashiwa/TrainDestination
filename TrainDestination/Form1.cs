namespace TrainDestination
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //��ʕ\���{�^��
        //��ʉ摜���擾����classification�s�N�`���{�b�N�X�ɕ\��
        private void classsf_Click(object sender, EventArgs e)
        {
            if (openclassific.ShowDialog() == DialogResult.OK)
            {
                classification.Load(openclassific.FileName);
            }
        }

        //�s��\���{�^��
        //�s��摜���擾����classification�s�N�`���{�b�N�X�ɕ\��
        private void dest_Click(object sender, EventArgs e)
        {
            if (opendestination.ShowDialog() == DialogResult.OK)
            {
                destination.Load(opendestination.FileName);
            }
        }

        //�ѐF�ύX�{�^��
        //�ŏ㕔�̕\���F��ύX
        private void changeLineColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Line.BackColor = colorDialog1.Color;
            }
        }


        //�\���������{�^��
        //��ʕ\���E�s��\���̉摜�\���̎�����
        private void cancel_Click(object sender, EventArgs e)
        {
            classification.Image = null;
            destination.Image = null;
        }

        //����{�^��
        //���̃t�H�[�������
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
