using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Lab9_brownianMotion.Forms;

namespace Lab9_brownianMotion
{
    public partial class MainForm : Form
    {
        private Random rand = new Random();
        private Task[] tasks;
        private int numOfMolec;

        private CancellationTokenSource cancelTokenSource;
        private CancellationToken token;
        public MainForm()
        {
            InitializeComponent();
        }

        public void TempBar_Scroll(object sender, EventArgs e)
        {
            TempLbl.Text = TempBar.Value.ToString();
            Particle.AdjustTemp(TempBar.Value);
        }

        public void StopBtn_Click(object sender, EventArgs e)
        {
            NumOfMolecules.Enabled = true;
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
            cancelTokenSource.Cancel();

            Task.WaitAll();
            Particle.Clear();
        }


        public void StartBtn_Click(object sender, EventArgs e)
        {
            NumOfMolecules.Enabled = false;
            StartBtn.Enabled = false;
            StopBtn.Enabled = true;
            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;
            numOfMolec = (int)NumOfMolecules.Value;

            Particle.SetUp(numOfMolec);
            tasks = new Task[numOfMolec];

            for (int i = 0; i < numOfMolec; ++i)
            {
                tasks[i] = Task.Run(() => ControlMolecule());
            }
        }

        public void ControlMolecule()
        {
            Particle mol = new Particle(
                      rand.Next(0, this.ClientSize.Width),
                      rand.Next(0, this.ClientSize.Height));

            this.Invoke(new MethodInvoker(() => { this.Controls.Add(mol); }));

            while (!token.IsCancellationRequested)
            {
                mol.Invoke(new MethodInvoker(() => { mol.MoveParticle(); }));
                
                Thread.Sleep(60/numOfMolec);
            }
            this.Invoke(new MethodInvoker(() => { this.Controls.Remove(mol); }));

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
