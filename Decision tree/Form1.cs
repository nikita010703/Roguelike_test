using Tree;

namespace Decision_tree {   
    public partial class Form1 : Form {
        DecisionTree tree;
        TreeViewHandler tvh;
        bool isQuestionNow;
        List<Button> btn;
        public Form1() {
            InitializeComponent();
            tree = new DecisionTree();
            tvh = new TreeViewHandler(tree, treeView);
            btn = new List<Button>() { btn0, btn1, btn2, btn3, btn4, btn5 };
            isQuestionNow = false;
            Update();
        }

        public void Update() {
            if (tree.getCurrentType() == "Question") {
                if (!isQuestionNow) {
                    DrawQuestion();
                    isQuestionNow = true;
                }
                for (int i = 0; i < tree.getCurrentAnswers().Count; ++i)
                    btn[i].Show();
                for (int i = tree.getCurrentAnswers().Count; i < 6; ++i)
                    btn[i].Hide();

                lblName.Text = tree.getCurrentQuestion();
                List<string> answers = tree.getCurrentAnswers();
                for (int i = 0; i < answers.Count; i++) {
                    btn[i].Text = answers[i];
                }
            }
            else {
                if (isQuestionNow) {
                    DrawAnswer();
                    isQuestionNow = false;
                }

                List<string> data = tree.getAnswerData();
                imgGame.ImageLocation = Directory.GetCurrentDirectory() + "\\img\\" + data[2];
                lblName.Text = data[0];
                lblDescription.Text = data[1];
            }
        }

        public void DrawQuestion() {
            imgGame.Hide();
            btnReset.Hide();
            lblDescription.Hide();
            panelBtn.Show();
        }

        public void DrawAnswer() {
            panelBtn.Hide();

            imgGame.Show();
            btnReset.Show();
            lblDescription.Show();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            tree.reset();
            Update();
        }

        private void btnAns_Click(object sender, EventArgs e) {
            int index = int.Parse((sender as Button).Tag.ToString());
            tree.getNextNode(index);
            Update();
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            tvh.findNode(e.Node.Text);
            Update();
        }

        private void treeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e) {
            e.Cancel = true;
        }
    }
}