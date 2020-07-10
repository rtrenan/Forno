using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Modbus.Device;


namespace Testeconnect
{
    public partial class Form1 : Form
    {
        SerialPort ports = new SerialPort();

        int funct = 0;
        int funct1 = 0;
        uint fun1 = 0;

        int start = 0;

        float time_s = 0;
        float time_m = 0;
        float time_h = 0;

        float t1 = 0;
        float t2 = 0;
        float t3 = 0;
        float t4 = 0;
        float ttotal = 0;
        int temp_h = 0;
        int temp_l = 0;
        double contador = 0;

        
        int tempo1v = 0;
        int tempo2v = 0;
        int tempo3v = 0;
        int tempo4v = 0;
        int tempo5v = 0;

        int set1v = 0;
        int set2v = 0;
        int set3v = 0;
        int set4v = 0;
        int set5v = 0;

        int box1 = 0;
        int box2 = 0;
        int box3 = 0;



        public Form1()
        {
            InitializeComponent();
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_sol.BackColor = Color.LightSalmon;
            btn_for.BackColor = Color.LightSalmon;
        }
                       
        private void timer1_Tick(object sender, EventArgs e)
        {
            IModbusSerialMaster master6 = ModbusSerialMaster.CreateRtu(ports);
            // Crônometro--------------------------------------------------------------------------------------------------


            if (time_s <= 59)
            {
                if (time_s < 10)
                {
                    txt_time.Text = Convert.ToString(time_h) + "0:0" + Convert.ToString(time_m) + ":0" + Convert.ToString(time_s);
                }
                else
                {
                    txt_time.Text = Convert.ToString(time_h) + "0:0" + Convert.ToString(time_m) + ":" + Convert.ToString(time_s);
                }
                
            }

            else if (time_m <= 59)
            {
                time_m++;
                time_s = 0;
                if (time_m < 10)
                {
                    txt_time.Text = Convert.ToString(time_h) + "0:0" + Convert.ToString(time_m) + ":0" + Convert.ToString(time_s) ;
                }
                else
                {
                    txt_time.Text = Convert.ToString(time_h) + "0:" + Convert.ToString(time_m) + ":" + Convert.ToString(time_s) ;
                }
            }
            else if (time_h < 999)
            {
                time_h++;
                time_s = 0;
                time_m = 0;
                if (time_h < 10)
                {
                    txt_time.Text = "0" + Convert.ToString(time_h) + ":0" + Convert.ToString(time_m) + ":0" + Convert.ToString(time_s) ;
                }
                else
                {
                    txt_time.Text = Convert.ToString(time_h) + ":" + Convert.ToString(time_m) + ":" + Convert.ToString(time_s) ;
                }
            }
            time_s++;

            try
            {

                ushort[] holding_register = master6.ReadHoldingRegisters(1, 0, 2); // Cria a Variável e recebe o 2 registradores

                float valor = Convert.ToSingle(holding_register[0]); // Transforma em um float para ser manipulado
                float valor1 = Convert.ToSingle(holding_register[1]);

                leitura.Text = Convert.ToString(valor1 / 10) + " °C"; // escreve o valor no 'box'
                leitura2.Text = Convert.ToString(valor / 10) + " °C";

                //Escrita dos Registradores de Configuração


                master6.WriteSingleRegister(1, 72, Convert.ToUInt16(box1));
                master6.WriteSingleRegister(1, 73, Convert.ToUInt16(box1));
                //master6.WriteSingleRegister(1, 13, Convert.ToUInt16(box2));
                master6.WriteSingleRegister(1, 94, Convert.ToUInt16(box3));

                master6.WriteSingleRegister(1, 96, Convert.ToUInt16(tempo1v));
                master6.WriteSingleRegister(1, 97, Convert.ToUInt16(tempo2v));
                master6.WriteSingleRegister(1, 98, Convert.ToUInt16(tempo3v));
                master6.WriteSingleRegister(1, 99, Convert.ToUInt16(tempo4v));
                master6.WriteSingleRegister(1, 100, Convert.ToUInt16(tempo5v));

                master6.WriteSingleRegister(1, 101, Convert.ToUInt16(set1v * 10));
                master6.WriteSingleRegister(1, 102, Convert.ToUInt16(set2v * 10));
                master6.WriteSingleRegister(1, 103, Convert.ToUInt16(set3v * 10));
                master6.WriteSingleRegister(1, 104, Convert.ToUInt16(set4v * 10));
                master6.WriteSingleRegister(1, 105, Convert.ToUInt16(set5v * 10));



            }
            catch (Exception err)
            {
                MessageBox.Show("Problema de comunicação");
            }
            
                
            

            //-------------------------------------------------------------------------------------------------------------

        }
         
        private void timer2_Tick(object sender, EventArgs e)
        {
        /*
            IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(ports);
            byte slaveId = Convert.ToByte(txtslave.Text);
            ushort startAddress = Convert.ToUInt16(txtaddress.Text);

            //master.WriteSingleRegister(slaveId, 47, Convert.ToUInt16(fun1));



            if (contador < t1)
            {
                master.WriteSingleCoil(slaveId, 2, false);
                btn_sol.Text = "DESLIGADO";

                master.WriteSingleCoil(slaveId, 4, false);
                btn_for.Text = "DESLIGADO";

                master.WriteSingleRegister(slaveId, 25, Convert.ToUInt16(temp_h * 10));

            }

            if (contador >= t1 && contador < t2)
            {

                master.WriteSingleCoil(slaveId, 4, true);
                btn_for.Text = "LIGADO";
                btn_for.BackColor = Color.LightGreen;
            }

            if (contador >= t2 && contador < t3)
            {
                master.WriteSingleCoil(slaveId, 2, true);
                btn_sol.Text = "LIGADO";
                btn_sol.BackColor = Color.LightGreen;
                master.WriteSingleRegister(slaveId, 25, Convert.ToUInt16(temp_l * 10));

                master.WriteSingleCoil(slaveId, 4, false);
                btn_for.Text = "DESLIGADO";
                btn_for.BackColor = Color.LightSalmon;
            }

            if (contador >= t3 && contador < t4)
            {
                master.WriteSingleCoil(slaveId, 2, false);
                btn_sol.Text = "DESLIGADO";
                btn_sol.BackColor = Color.LightSalmon;

                master.WriteSingleCoil(slaveId, 4, true);
                btn_for.Text = "LIGADO";
                btn_for.BackColor = Color.LightGreen;
            }

            if (contador >= t4)
            {
                master.WriteSingleCoil(slaveId, 2, false);
                btn_sol.Text = "DESLIGADO";
                btn_sol.BackColor = Color.LightSalmon;

                master.WriteSingleCoil(slaveId, 4, false);
                btn_for.Text = "DESLIGADO";
                btn_for.BackColor = Color.LightSalmon;
            }

            //Escrita/Leitura dos Registradores
            //temperatura e TEMP-SET
            ushort[] holding_register = master.ReadHoldingRegisters(slaveId, startAddress, 2); // Cria a Variável e recebe o 2 registradores

            float valor = Convert.ToSingle(holding_register[0]); // Transforma em um float para ser manipulado
            float valor1 = Convert.ToSingle(holding_register[1]);

            leitura.Text = Convert.ToString(valor1 / 10); // escreve o valor no 'box'
            leitura2.Text = Convert.ToString(valor / 10);

            contador++;
            */
        }

        
        private void button1_Click(object sender, EventArgs e)
                   
      {
            IModbusSerialMaster master5 = ModbusSerialMaster.CreateRtu(ports);

            try
            {
                if (start == 1)
                {
                    timer1.Enabled = false;
                    //timer2.Enabled = false;

                    button1.Text = "Desconnected";
                    button1.BackColor = Color.Red;

                    btn_for.Enabled = true;
                    btn_sol.Enabled = true;

                    master5.WriteSingleRegister(1, 47, 0);
                    master5.WriteSingleRegister(1, 61, 0);
                    master5.WriteSingleRegister(1, 59, 0);


                    time_h = 0;
                    time_s = 0;
                    time_m = 0;

                    txt_time.Text = Convert.ToString(time_h) + "0:0" + Convert.ToString(time_m) + ":0" + Convert.ToString(time_s) ;

                    //fun1 = 0;
                    //contador = 0;

                    start = 0;
                                                           }
                else
                {

                    //Ativa o RUN e set para saida i/o 5 seja saída (5)
                    master5.WriteSingleRegister(1, 47, 1);
                   // master5.WriteSingleRegister(1, 73, Convert.ToUInt16(box1));

                    timer1.Enabled = true;
                    //timer2.Enabled = true;
                    btn_for.Enabled = false;
                    btn_sol.Enabled = false;
                    button1.Text = "Connected";
                    button1.BackColor = Color.Green;
                    //fun1 = 1;

                    master5.WriteSingleRegister(1, 61, 5);
                    master5.WriteSingleRegister(1, 59, 6);

                    start = 1;
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Erro de Porta!");
                            }
        }

       

        private void comunicaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            

            ports.PortName = form2.comboBox1.Text;
            ports.BaudRate = Convert.ToInt16(form2.comboBox2.Text);
            ports.DataBits = Convert.ToByte(form2.comboBox4.Text);
            ports.Parity = (Parity)Enum.Parse(typeof(Parity), form2.comboBox3.Text);
            ports.StopBits = (StopBits)Enum.Parse(typeof(StopBits), form2.comboBox5.Text);

        }

        private void rampaTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            //form3.ShowDialog();

            t1 = Convert.ToInt16(form3.txt_t1.Text);
            t2 = Convert.ToInt16(form3.txt_t2.Text);
            t3 = Convert.ToInt16(form3.txt_t3.Text);
            t4 = Convert.ToInt16(form3.txt_t4.Text);
            ttotal = Convert.ToInt16(form3.txt_total.Text);
            temp_h = Convert.ToInt16(form3.txt_temph.Text);
            temp_l = Convert.ToInt16(form3.txt_templ.Text);


        }

        private void btn_sol_Click(object sender, EventArgs e)
        {
            IModbusSerialMaster master2 = ModbusSerialMaster.CreateRtu(ports);
            

            if (funct == 0)
            {
                funct = 1;
                btn_sol.Text = "LIGADO";
                btn_sol.BackColor = Color.LightGreen;
                master2.WriteSingleCoil(1, 2, true);
            }
            else if (funct == 1){
                funct = 0;
                btn_sol.Text = "DESLIGADO";
                btn_sol.BackColor = Color.LightCoral;
                master2.WriteSingleCoil(1, 2, false);
            }
                 
        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            IModbusSerialMaster master3 = ModbusSerialMaster.CreateRtu(ports);

            if (funct1 == 0)
            {
                funct1 = 1;
                btn_for.Text = "LIGADO";
                btn_for.BackColor = Color.LightGreen;
                master3.WriteSingleCoil(1, 4, true);
            }
            else if (funct1 == 1)
            {
                funct1 = 0;
                btn_for.Text = "DESLIGADO";
                btn_for.BackColor = Color.LightCoral;
                master3.WriteSingleCoil(1, 4, false);

            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            try
            {
                if (ports.IsOpen)
                {
                    ports.Close();
                    btn_open.Text = "FECHADO";
                    btn_open.BackColor = Color.Red;
                }
                else
                {
                    ports.Open();
                    btn_open.Text = "ABERTO";
                    btn_open.BackColor = Color.Green;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro de Porta!");
            }
        }

        private void programaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
            IModbusSerialMaster master4 = ModbusSerialMaster.CreateRtu(ports);
            try
            {

                tempo1v = Convert.ToInt16(form4.tempo1v.Text);
                tempo2v = Convert.ToInt16(form4.tempo2v.Text);
                tempo3v = Convert.ToInt16(form4.tempo3v.Text);
                tempo3v = Convert.ToInt16(form4.tempo3v.Text);
                tempo3v = Convert.ToInt16(form4.tempo3v.Text);


                set1v = Convert.ToInt16(form4.setv1.Text);
                set2v = Convert.ToInt16(form4.setv2.Text);
                set3v = Convert.ToInt16(form4.setv3.Text);
                set3v = Convert.ToInt16(form4.setv3.Text);
                set3v = Convert.ToInt16(form4.setv3.Text);

                box1 = Convert.ToInt16(form4.box1.Text);
                box2 = Convert.ToInt16(form4.box2.Text);
                //box3 = Convert.ToInt16(form4.box3.Text);

                /*
                master4.WriteSingleRegister(1, 72, Convert.ToUInt16(box1));
                master4.WriteSingleRegister(1, 13, Convert.ToUInt16(box2));
                master4.WriteSingleRegister(1, 96, Convert.ToUInt16(box3));

                master4.WriteSingleRegister(1, 98, Convert.ToUInt16(tempo1v));
                master4.WriteSingleRegister(1, 99, Convert.ToUInt16(tempo2v));
                master4.WriteSingleRegister(1, 100, Convert.ToUInt16(tempo3v));

                master4.WriteSingleRegister(1, 103, Convert.ToUInt16(set1v));
                master4.WriteSingleRegister(1, 104, Convert.ToUInt16(set2v));
                master4.WriteSingleRegister(1, 105, Convert.ToUInt16(set3v));
                */

            }
            catch (Exception err)
            {
                MessageBox.Show("Carregue valores!");
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            ports.Close();
        }
    }
}