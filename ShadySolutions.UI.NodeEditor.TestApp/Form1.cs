using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadySolutions.UI.NodeEditor.TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /// Diffuse
            Node Diffuse = new Node("Diffuse BSDF");
            NodeValueOutput BSDF = new NodeValueOutput("BSDF");
            NodeValueColor Color = new NodeValueColor("Color");
            Color.Value = new ValueVector(1, 1, 1, 1);
            NodeValueFloat Roughness = new NodeValueFloat("Roughness");
            Diffuse.AddNodeValue(BSDF);
            Diffuse.AddNodeValue(Color);
            Diffuse.AddNodeValue(Roughness);
            Editor.AddNode(Diffuse);
            /// Material Output
            Node Output = new Node("Material Output");
            NodeValueVector Surface = new NodeValueVector("Surface");
            NodeValueVector Volume = new NodeValueVector("Volume");
            NodeValueVector Displacement = new NodeValueVector("Displacement");
            Output.AddNodeValue(Surface);
            Output.AddNodeValue(Volume);
            Output.AddNodeValue(Displacement);
            //BSDF.Outputs.Add(Surface);
            //Surface.Input = BSDF;
            Editor.AddNode(Output);
        }
    }
}
