using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Star
{

    public partial class Sliding_Puzzle : Form
    {
        public int[,] initial;
        public int[,] final;
        public int sat = 0;
        public int sut = 0;
        public int sat2 = 0;
        public int sut2 = 0;
        public bool tm = true;
        public bool tm2 = true;

        public Sliding_Puzzle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sliding_Puzzle_Load(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        int k = 0;
        private List<int[,]> AStarıBaslat()
        {


            int[,] puzzleMatrix = initial;
            int[,] hedefMatrix = final;



            List<int[,]> cozum = AStar(initial, final);

            if (cozum.Count == 0) { label3.Text = "Çözüm bekleenden uzun sürdü arama iptal edildi"; }
            else
            {

                for (int i = 0; i < cozum.Count; i++)
                {

                    listBox1.Items.Add($"Adım {i + 1}:");
                    PrintMatrixToListBox(cozum[i], listBox1);
                }
                label3.Text = "Çözüm tamamlandı";
            }
           

            return cozum;
        }

        static int[,] HedefDurumOlustur(int satır, int sutun)
        {

            int[,] hedef = new int[satır, sutun];
            int say = 1;
            int son = satır * sutun;

            for (int i = 0; i < satır; i++)
            {
                for (int j = 0; j < sutun; j++)
                {

                    if (say == son)
                    {
                        hedef[i, j] = 0; break;
                    }
                    hedef[i, j] = say;
                    say++;

                }
            }

            return hedef;
        }

        static int[,] CreateRandomPuzzleMatrix(int satır, int sutun)
        {
            Random rand = new Random();
            int[,] matrix = new int[satır, sutun];

            List<int> numbers = new List<int>();

            for (int i = 0; i <= satır * sutun - 1; i++)
            {
                numbers.Add(i);
            }

            for (int i = 0; i < satır; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    int index = rand.Next(numbers.Count);
                    matrix[i, j] = numbers[index];
                    numbers.RemoveAt(index);
                }
            }

            return matrix;
        }


        static void PrintMatrixToListBox(int[,] matrix, ListBox listBox)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);



            for (int i = 0; i < rows; i++)
            {
                string rowText = ""; 

            
                for (int j = 0; j < columns; j++)
                {
                    rowText += matrix[i, j].ToString() + "\t";
                }
                listBox.Items.Add(rowText);
            }
        }

        public List<int[,]> AStar(int[,] initialState, int[,] goalState)
        {
            // Açık listeyi ve kapalı liste
            List<Node> openList = new List<Node>();// openlist in düğüm tanımlarını düzelttim 2d matrix için uygun burası tamam.
            HashSet<Node> closedList = new HashSet<Node>();
            int satır = initialState.GetLength(0);
            int sutun = initialState.GetLength(1);


            // Başlangıç düğümü
            Node startNode = new Node(initialState, 0, CalculateHeuristic(initialState, goalState), null);
            openList.Add(startNode);

            int k = 0;
            while (openList.Count > 0)
            {
                // en uygun düğüm
                Node currentNode = openList[0];
                for (int i = 1; i < openList.Count; i++)
                {

                    if (openList[i].F < currentNode.F)
                    {
                        currentNode = openList[i];
                    }
                }


                openList.Remove(currentNode);
                closedList.Add(currentNode);

                if (IsEqual(currentNode.State, goalState, satır, sutun))
                {
                    return ReconstructPath(currentNode);
                }

                foreach (var neighborState in GetNeighborStates(currentNode.State, satır, sutun))
                {
                    Node neighborNode = new  Node(neighborState, currentNode.G + 1, CalculateHeuristic(neighborState, goalState), currentNode);

                    if (!openList.Contains(neighborNode) || neighborNode.F < openList[openList.IndexOf(neighborNode)].F)
                    {
                        if (!openList.Contains(neighborNode))
                        {
                            openList.Add(neighborNode);
                        }
                        else
                        {

                            var existingNode = openList.Find(n => IsEqual(n.State, neighborNode.State, satır, sutun));
                            if (existingNode != null && neighborNode.G < existingNode.G)
                            {
                                existingNode.G = neighborNode.G;
                                existingNode.Parent = currentNode;
                            }
                        }
                    }
                    k++;
                    if (k > 120000) return new List<int[,]>();
                    label9.Visible = true;
                    label9.Text = $"{k} düğüm hesaplandı";
                }




            }
            return new List<int[,]>();
        }
        static bool IsEqual(int[,] state1, int[,] state2, int satır, int sutun)
        {
            for (int i = 0; i < satır; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    if (state1[i, j] != state2[i, j])
                    {

                        return false;
                    }
                }
            }
            Console.WriteLine("Uyumlu   yes");
            return true;
        }

        static int CalculateHeuristic(int[,] currentState, int[,] goalState)
        {
            // tüm elemanlar için hedef duruma uzaklığı hesaplar ve hepsini tıplar
            // Manhattan mesafesi 
            int distance = 0;
            int satır = goalState.GetLength(0);
            int sutun = goalState.GetLength(1);
            for (int i = 0; i < satır; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    if (currentState[i, j] != 0) // Boş hücre değilse devam et
                    {
                        int currentRow = i;
                        int currentCol = j;
                        int goalValue = currentState[i, j]; // Hedef durumdaki değeri bul
                        for (int m = 0; m < satır; m++)
                        {
                            for (int n = 0; n < sutun; n++)
                            {
                                if (goalState[m, n] == goalValue) // Hedef durumdaki indeksi bul
                                {
                                    int goalRow = m;
                                    int goalCol = n;
                                    distance += Math.Abs(currentRow - goalRow) + Math.Abs(currentCol - goalCol);
                                }
                            }
                        }
                    }
                }
            }
            return distance;
        }
        static List<int[,]> GetNeighborStates(int[,] currentState, int satır, int sutun)
        {
            // Boş hücrenin indeksini bul
            int zeroRow = -1;
            int zeroCol = -1;
            for (int i = 0; i < satır; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    if (currentState[i, j] == 0)
                    {
                        zeroRow = i;
                        zeroCol = j;
                        break;
                    }
                }
                if (zeroRow != -1)
                    break;
            }


            // Komşu durumları oluştur
            List<int[,]> neighborStates = new List<int[,]>();

            // Yukarı hareket
            if (zeroRow > 0)
            {
                int[,] newState = (int[,])currentState.Clone();
                newState[zeroRow, zeroCol] = newState[zeroRow - 1, zeroCol];
                newState[zeroRow - 1, zeroCol] = 0;
                neighborStates.Add(newState);
            }
            // Aşağı hareket
            if (zeroRow < satır - 1)
            {
                int[,] newState = (int[,])currentState.Clone();
                newState[zeroRow, zeroCol] = newState[zeroRow + 1, zeroCol];
                newState[zeroRow + 1, zeroCol] = 0;
                neighborStates.Add(newState);
            }
            // Sol hareket
            if (zeroCol > 0)
            {
                int[,] newState = (int[,])currentState.Clone();
                newState[zeroRow, zeroCol] = newState[zeroRow, zeroCol - 1];
                newState[zeroRow, zeroCol - 1] = 0;
                neighborStates.Add(newState);
            }
            // Sağ hareket
            if (zeroCol < sutun - 1)
            {
                int[,] newState = (int[,])currentState.Clone();
                newState[zeroRow, zeroCol] = newState[zeroRow, zeroCol + 1];
                newState[zeroRow, zeroCol + 1] = 0;
                neighborStates.Add(newState);
            }

            return neighborStates;
        }

        static List<int[,]> ReconstructPath(Node node)
        {
            List<int[,]> path = new List<int[,]>();
            while (node != null)
            {
                path.Insert(0, node.State);
                node = node.Parent;
            }


            return path;
        }
        class Node
        {
            public int[,] State { get; set; }
            public int G { get; set; }
            public int H { get; set; }
            public int F { get { return G + H; } set { F = value; } }
                
            public Node Parent { get; set; }

            public Node(int[,] state, int g, int h, Node parent)
            {
                State = state;
                G = g;
                H = h;
                Parent = parent;
            }
        }



        private void H(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Degisim();
        }
        public void Degisim()
        {
            if (radioButton1.Checked)
            {
                button4.Visible = false;
                Olustur.Visible = true;

                tm = false;
                tm2 = false;
            }
            else
            {
                button4.Visible = true;
                Olustur.Visible = false;
                groupBox3.Visible = false;

            }
        }
        public bool Kontrol(string inp)
        {
            if (!IsNumeric(inp) || !IsPositiveNumber(inp))
            {
                MessageBox.Show("Lütfen geçerli bir değer girin");
                return false;
            }

            return true;
        }

        static bool IsPositiveNumber(string input)
        {
            if (input == "0") return true;
            bool isPositive = false;
            if (IsNumeric(input))
            {
                double number = double.Parse(input);
                if (number > 0)
                {
                    isPositive = true;
                }
            }
            return isPositive;
        }

        // Girdinin sadece sayısal bir değer olup olmadığını kontrol eden fonksiyon
        static bool IsNumeric(string input)
        {
            if (input == "0") return true;
            bool isNumeric = double.TryParse(input, out _);
            return isNumeric;
        }

        public void button4_Click(object sender, EventArgs e)
        {

            if (Kontrol(Satır.Text) && Kontrol(Sutun.Text))
            {
                listBox2.Items.Clear();
                initial = CreateRandomPuzzleMatrix(int.Parse(Satır.Text), int.Parse(Sutun.Text));
                PrintMatrixToListBox(initial, listBox2);
                tm = true;
                groupBox1.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Kontrol(Satır.Text) || !Kontrol(Sutun.Text)) return;
            sat = 0;
            sut = 0;
            sat2 = 0;
            sut2 = 0;
            label5.Text = "1. Değeri Girin";
            label1.Text = "1. Değeri Girin";
            int a = int.Parse(Satır.Text);
            int b = int.Parse(Sutun.Text);
            final = new int[a, b];
            initial = new int[a, b];
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            groupBox3.Visible = true;
            groupBox1.Visible = true;
            tm = true;
            tm2 = true;
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            if (tm)
            {
                if (sat < initial.GetLength(0) || sut + 1 < initial.GetLength(1))
                {
                    if (!Kontrol(Deger.Text)) return;
                    initial[sat, sut] = int.Parse(Deger.Text);
                    if (sut == initial.GetLength(1) - 1)
                    {
                        if (sat == initial.GetLength(0) - 1) { listBox2.Items.Clear(); tm = false; PrintMatrixToListBox(initial, listBox2); }
                        else
                            sat++;
                        sut = 0;
                        label1.Text = $"{(sat * initial.GetLength(0)) + sut + 1}. Değeri giriniz";

                    }
                    else
                    {
                        sut++;
                        label1.Text = $"{(sat * initial.GetLength(0)) + sut + 1}. Değeri giriniz";
                    }
                }
                else
                {
                    AStarıBaslat();
                }
                Deger.Clear();
            }
            else
            {
                MessageBox.Show("Matris zaren hazır");
                Deger.Clear();
            }

        }


        private void Hesapla_Click(object sender, EventArgs e)
        {
            
            if (tm == false|| tm2==false )
            {
                if (!MatrisKontrol(final) || !MatrisKontrol(initial)) return;
                label3.Text = "Hesaplanıyor lüten bekleyiniz ...";
                listBox1.Items.Clear();
                label3.Visible = true;
                label3.Text = "Hesaplanıyor lüten bekleyiniz ...";
                
                Thread.Sleep(500);
                AStarıBaslat();
                

            }
            else
            {
                MessageBox.Show("Önce hedef ve başlangıç Matrislerini Hazırlayın");
            }
        }

        public void Sıfırla()
        {
            listBox2.Items.Clear();
            sat = 0;
            sut = 0;
            tm=true; 
            label1.Text = "1. Değeri giriniz";
            initial = new int[initial.GetLength(0), initial.GetLength(1)];
        }
        public void Sıfırla2()
        {
            listBox3.Items.Clear();
            sat2 = 0;
            tm2 = true;
            sut2 = 0;
            label5.Text = "1. Değeri giriniz";
            initial = new int[initial.GetLength(0), initial.GetLength(1)];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sıfırla();
        }

        public bool MatrisKontrol(int[,] matris)
        {
            List<int> kontrol = new List<int>();
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    kontrol.Add(matris[i, j]);
                }
            }
            kontrol.Sort();
            for (int i = 1; i < kontrol.Count; i++)
            {
                if (kontrol[i] != kontrol[i - 1] + 1)
                {
                    Sıfırla();
                    Sıfırla2();
                    MessageBox.Show("Hatalı Matris var ve matrisler sıfırandı");
                    
                    return false;
                }
            }

            List<int> kontrol1 = new List<int>();
            List<int> kontrol2 = new List<int>();
            for (int i = 0; i < final.GetLength(0); i++)
            {
                for (int j = 0; j < final.GetLength(1); j++)
                {
                    kontrol1.Add(final[i, j]);
                }
            }
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    kontrol2.Add(initial[i, j]);
                }
            }

            kontrol1.Sort();
            kontrol2.Sort();

            for (int i = 0; i < kontrol1.Count; i++)
            {
                if (kontrol1[i] != kontrol2[i])
                {
                    Sıfırla();
                    Sıfırla2();
                    MessageBox.Show("Matrisler Uyuşmuyor matrisler sıfırlandı !");
                    return false;
                }
            }



            return true;

        }

        public void HedefOlustur()
        {
            listBox3.Items.Clear(); tm2 = false; PrintMatrixToListBox(final, listBox3);
        }
        private void Ekle2_Click(object sender, EventArgs e)
        {
            if (tm2)
            {
                if (sat2 < final.GetLength(0) || sut2 + 1 < final.GetLength(1))
                {
                    if (!Kontrol(Deger2.Text)) return;
                    final[sat2, sut2] = int.Parse(Deger2.Text);
                    if (sut2 == final.GetLength(1) - 1)
                    {
                        if (sat2 == initial.GetLength(0) - 1) { HedefOlustur(); }
                        else
                            sat2++;
                        sut2 = 0;
                        label5.Text = $"{(sat2 * initial.GetLength(0)) + sut2 + 1}. Değeri giriniz";

                    }
                    else
                    {
                        sut2++;
                        label5.Text = $"{(sat2 * initial.GetLength(0)) + sut2 + 1}. Değeri giriniz";
                    }
                }

                Deger2.Clear();
            }
            else
            {
                MessageBox.Show("Matris zaren hazır");
                Deger2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sıfırla2();
        }

        private void HedefM_Click(object sender, EventArgs e)
        {
            final = HedefDurumOlustur(initial.GetLength(0),initial.GetLength(1));
            HedefOlustur();
        }
    }

}


