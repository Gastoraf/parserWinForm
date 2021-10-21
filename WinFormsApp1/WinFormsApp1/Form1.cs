using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {

        
        
        public Form1()
        {
            InitializeComponent();

        }

        
        private void XmlTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:/Users/gastoraf/source/repos/WinFormsApp1/WinFormsApp1/test.xml");

            XmlElement rootX = xmlDoc.DocumentElement;
            if (XmlTree.SelectedNode.Level == 0)
            {
                rootX.RemoveChild(rootX.ChildNodes[XmlTree.SelectedNode.Index]);
            }
            else
            {
                rootX.ChildNodes[XmlTree.SelectedNode.Parent.Index].RemoveChild(rootX.ChildNodes[XmlTree.SelectedNode.Index]);
            }
            XmlTree.SelectedNode.Remove();
            xmlDoc.Save("C:/Users/gastoraf/source/repos/WinFormsApp1/WinFormsApp1/test.xml");
        }


        private void getData_Click(object sender, EventArgs e)
        {
            XmlTree.Nodes.Clear();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:/Users/gastoraf/source/repos/WinFormsApp1/WinFormsApp1/test.xml");

            XmlElement rootEl = xmlDoc.DocumentElement;
            foreach (XmlNode quest in rootEl)
            {
                TreeNode node = new TreeNode();
                node.Text = quest.ChildNodes[0].InnerText;
                for (int i = 1; i < quest.ChildNodes.Count; i++)
                {
                    string str = quest.ChildNodes[i].ChildNodes[0].InnerText;
                    if (quest.ChildNodes[i].Attributes[1].Value == "1")
                        str += "- правильный ответ";

                    node.Nodes.Add(new TreeNode().Text = str);
                }
                XmlTree.Nodes.Add(node);
            }


        }



        private void addQuestion_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:/Users/gastoraf/source/repos/WinFormsApp1/WinFormsApp1/test.xml");

            XmlElement rootEl = xmlDoc.DocumentElement;

            XmlElement newQ = xmlDoc.CreateElement("question");
            newQ.SetAttribute("id", rootEl.ChildNodes.Count.ToString());
            newQ.SetAttribute("difficulty", dif.Text);
            newQ.SetAttribute("time", time.Text);
            newQ.SetAttribute("mark", mark.Text);
            XmlElement qText = xmlDoc.CreateElement("text");
            qText.InnerText = textQuestion.Text;
            newQ.AppendChild(qText);
            rootEl.AppendChild(newQ);

            xmlDoc.Save("C:/Users/gastoraf/source/repos/WinFormsApp1/WinFormsApp1/test.xml");
        }

        

        private void addAnswer_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:/Users/gastoraf/source/repos/WinFormsApp1/WinFormsApp1/test.xml");

            XmlElement rootEl = xmlDoc.DocumentElement;
            XmlNode quest = rootEl.ChildNodes[XmlTree.SelectedNode.Index];

            XmlElement newAns = xmlDoc.CreateElement("answer");
            newAns.SetAttribute("id", (quest.ChildNodes.Count + 1).ToString());
            newAns.SetAttribute("isRight", isRight.Text.ToString());

            XmlElement textElement = xmlDoc.CreateElement("text");
            textElement.InnerText = textAnswer.Text;

            newAns.AppendChild(textElement);
            quest.AppendChild(newAns);

            xmlDoc.Save("C:/Users/gastoraf/source/repos/WinFormsApp1/WinFormsApp1/test.xml");

        }

        private void updateAnswer_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:/Users/gastoraf/source/repos/WinFormsApp1/WinFormsApp1/test.xml");

            XmlElement rootEl = xmlDoc.DocumentElement;
            XmlNode quest = rootEl.ChildNodes[XmlTree.SelectedNode.Index];

            quest.ChildNodes[int.Parse(numAnswer.Text)].ChildNodes[0].InnerText = textAnswer.Text;
            quest.ChildNodes[int.Parse(numAnswer.Text)].Attributes[1].Value = isRight.Text;

            xmlDoc.Save("C:/Users/gastoraf/source/repos/WinFormsApp1/WinFormsApp1/test.xml");
        }

        private void updateQuestion_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:/Users/gastoraf/source/repos/WinFormsApp1/WinFormsApp1/test.xml");

            XmlElement rootEl = xmlDoc.DocumentElement;

            rootEl.ChildNodes[XmlTree.SelectedNode.Index].Attributes[0].Value = dif.Text;
            rootEl.ChildNodes[XmlTree.SelectedNode.Index].Attributes[1].Value = time.Text;
            rootEl.ChildNodes[XmlTree.SelectedNode.Index].Attributes[2].Value = type.Text;
            rootEl.ChildNodes[XmlTree.SelectedNode.Index].Attributes[3].Value = mark.Text;
            rootEl.ChildNodes[XmlTree.SelectedNode.Index].ChildNodes[0].InnerText = textQuestion.Text;

            xmlDoc.Save("C:/Users/gastoraf/source/repos/WinFormsApp1/WinFormsApp1/test.xml");
        }
    }
}
