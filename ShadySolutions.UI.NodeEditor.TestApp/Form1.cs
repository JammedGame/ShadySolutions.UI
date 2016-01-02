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
            Node Diffuse = new Node("Diffuse");
            NodeValueOutput Output = new NodeValueOutput("Output");
            NodeValueColor Color = new NodeValueColor("Color");
            Color.Value = new ValueVector(1, 1, 1, 1); 
            Diffuse.AddNodeValue(Output);
            Diffuse.AddNodeValue(Color);
            Editor.AddNode(Diffuse);
            /// Specular
            Node Specular = new Node("Specular");
            NodeValueOutput Output1 = new NodeValueOutput("Output");
            NodeValueColor SpecularV = new NodeValueColor("Specular");
            SpecularV.Value = new ValueVector(0, 0, 0.5, 1);
            NodeValueFloat Shininess = new NodeValueFloat("Shininess");
            Specular.AddNodeValue(Output1);
            Specular.AddNodeValue(SpecularV);
            Specular.AddNodeValue(Shininess);
            Editor.AddNode(Specular);
            /// Combine Shader
            Node CombineShader = new Node("Combine");
            NodeValueOutput Output3 = new NodeValueOutput("Combined");
            NodeValueColor Input1 = new NodeValueColor("Input 1");
            NodeValueColor Input2 = new NodeValueColor("Input 2");
            CombineShader.AddNodeValue(Output3);
            CombineShader.AddNodeValue(Input1);
            CombineShader.AddNodeValue(Input2);
            Editor.AddNode(CombineShader);
            /// Surface Result
            Node SurfaceResult = new Node("Surface Result");
            NodeValueOutput Output5 = new NodeValueOutput("Result");
            SurfaceResult.AddNodeValue(Output5);
            Editor.AddNode(SurfaceResult);
            /// Posterization
            Node Posterization = new Node("Posterization");
            NodeValueOutput Output4 = new NodeValueOutput("Processed");
            NodeValueFloat Thickness = new NodeValueFloat("Thickness");
            NodeValueFloat Intensity = new NodeValueFloat("Intensity");
            NodeValueColor Input = new NodeValueColor("Input");
            Posterization.AddNodeValue(Output4);
            Posterization.AddNodeValue(Thickness);
            Posterization.AddNodeValue(Intensity);
            Posterization.AddNodeValue(Input);
            Editor.AddNode(Posterization);
            /// Material Output
            Node Output2 = new Node("Material Output");
            NodeValueVector Surface = new NodeValueVector("Surface");
            Surface.HasValue = false;
            NodeValueVector Volume = new NodeValueVector("Displacement");
            Volume.HasValue = false;
            NodeValueVector Displacement = new NodeValueVector("Post Processing");
            Displacement.HasValue = false;
            Output2.AddNodeValue(Surface);
            Output2.AddNodeValue(Volume);
            Output2.AddNodeValue(Displacement);
            //BSDF.Outputs.Add(Surface);
            //Surface.Input = BSDF;
            Editor.AddNode(Output2);
        }
    }
}
