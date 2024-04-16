using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision_tree;
using Tree;

namespace Decision_tree {
    internal class TreeViewHandler {
        private DecisionTree tree;
        private TreeView tv;

        public TreeViewHandler(DecisionTree tree, TreeView tv) {
            this.tree = tree;
            this.tv = tv;

            tv.BeginUpdate();
            tv.Nodes.Add((tree.root as DecisionTree.QuestionNode).question);
            dfs(tree.root, tv.Nodes[0]);
            tv.EndUpdate();
            tv.ExpandAll();
        }

        private void dfs(DecisionTree.Node node, TreeNode curNode) {
            var newNode = node as DecisionTree.QuestionNode;
            for (int i = 0; i < newNode.nextQuestions.Count; ++i) {
                if (newNode.nextQuestions[i] is DecisionTree.QuestionNode) {
                    curNode.Nodes.Add((newNode.nextQuestions[i] as DecisionTree.QuestionNode).question);
                    dfs(newNode.nextQuestions[i], curNode.Nodes[i]);
                }
                else {
                    curNode.Nodes.Add((newNode.nextQuestions[i] as DecisionTree.AnswerNode).name);
                }
            }
        }

        public void findNode(string name) {
            Queue<DecisionTree.Node> queue = new Queue<DecisionTree.Node>();
            queue.Enqueue(tree.root);
            DecisionTree.Node ansNode = tree.root;

            while (queue.Count > 0) {
                if (queue.Peek() is DecisionTree.QuestionNode) {
                    DecisionTree.QuestionNode node = queue.Dequeue() as DecisionTree.QuestionNode;
                    if (node.question == name) {
                        ansNode = node;
                        queue.Clear();
                        break;
                    }
                    foreach (var child in node.nextQuestions)
                        queue.Enqueue(child);
                }
                else {
                    DecisionTree.AnswerNode node = queue.Dequeue() as DecisionTree.AnswerNode;
                    if (node.name == name) {
                        ansNode = node;
                        queue.Clear();
                        break;
                    }
                }
            }
            tree.CurNode = ansNode;
        }
    }
}
