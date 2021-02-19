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


namespace Supervisorio
{
    public partial class Form1 : Form
    {
        
        delegate void fuctionReception();
        public Form1()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);  // pega o que estiver na serial                                                       
        }
        void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            fuctionReception receptionDelegate = new fuctionReception(ReceptionSerial); // transfere para funcao ReceptionSerial
            Invoke(receptionDelegate);
        }

//======================================================================================
//                         Reception Serial         
//=======================================================================================
        String txt = null, str =null;
        long timeX1 = 0;
        long timeX2 = 0;
      
        bool status = false;
        public void ReceptionSerial()
        {
            //limpar o texto do Reception
            if(tb_reception.Text.Length > 776)
            {
                tb_reception.Clear();
            }

            // lê o que estiver na serial
            txt += serialPort1.ReadExisting();
            tb_reception.Text += txt;
            str += txt;
            txt = null;
            if (str.Substring(0, 1).Equals("["))// sensor 1 = [s132.00C] sensor 2= [s232.00%]
            {
                if (str.Length >= 8)
                {
                    if (str.Substring(1, 1).Equals("A") & str.Substring(7, 1).Equals("]"))
                    {
                        if (str.Substring(2, 1).Equals("1"))
                        {
                            lb_sensor1.Text = str.Substring(3, 4);
                            //cria efeito dinamico
                            if (g_sensor1.Series[0].Points.Count > 5)
                            {
                                g_sensor1.Series[0].Points.RemoveAt(0);
                                g_sensor1.Update(); // atualiza 
                            }


                            g_sensor1.Series[0].Points.AddXY(timeX1, Int32.Parse(str.Substring(3, 4)));


                        }
                        else
                        {
                            if (str.Substring(2, 1).Equals("2"))
                            {
                                lb_sensor2.Text = str.Substring(3, 4);


                                if (g_sensor2.Series[0].Points.Count > 5)
                                {
                                    g_sensor2.Series[0].Points.RemoveAt(0);
                                    g_sensor2.Update(); // atualiza 
                                }

                                g_sensor2.Series[0].Points.AddXY(timeX2, Int32.Parse(str.Substring(3, 4)));
                            }
                            //str = null;
                        }
                        timeX1++;
                        timeX2++;
                        str = null;
                    }
                    else
                    {

                        //[timer1ok]
                        if (str.Substring(1, 1).Equals("T") &//[TIMEOK]
                            str.Substring(2, 1).Equals("I") &
                            str.Substring(3, 1).Equals("M") &
                            str.Substring(4, 1).Equals("E") &
                            str.Substring(5, 1).Equals("O") &
                            str.Substring(6, 1).Equals("K") &
                            str.Substring(7, 1).Equals("]"))

                        {
                            
                            str = null;
                        }
                    }
                    str = null;
                }
                else if (str.Length >= 5)
                {
                    if (str.Substring(1, 1).Equals("O") &
                    str.Substring(2, 1).Equals("K") &
                    str.Substring(3, 1).Equals("!") &
                    str.Substring(4, 1).Equals("]"))
                    {//[OK!]    
                        status = true;
                    }
                    str = null;
                }
               



                //str = null;
            }
            else
            {
                str = null;
            }



        }// end  ReceptionSerial()

        private void lb_port_Click(object sender, EventArgs e)
        {

        }
//===========================================================================================
//                              Exit
//=========================================================================================
        private void bt_exit_Click(object sender, EventArgs e)
        {   // fecha o app
            Close();
        }
//========================================================================================
//                               Load
//=======================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
           

            #region config_port
            // recebe todas as portas seriais do pc disponiveis
            String[] valuesPort = SerialPort.GetPortNames();

            for( int i =0; i< valuesPort.Length; i++)
            {
                cb_port1.Items.Add(valuesPort[i]);
            }
            cb_port1.Text = "COM1";

            #endregion

            #region config_Baud
            int[] valueBauld = { 2400, 4800, 9600, 19200, 57600, 115200 };
            for (int i = 0; i < valueBauld.Length; i++)
            {
                cb_bould.Items.Add(valueBauld[i].ToString());
            }
            cb_bould.Text = "9600";
            #endregion

            #region config_Data
            
            cb_data.Items.Add("7");
            cb_data.Items.Add("8");
          
            cb_data.Text = "8";
            #endregion

            #region config_Stop

            cb_bits.Items.Add("None");
            cb_bits.Items.Add("One");
            cb_bits.Items.Add("Two");

            cb_bits.Text = "One";
            #endregion

            #region config_Parity

            cb_parity.Items.Add("NONE");
            cb_parity.Items.Add("EVEN");
            cb_parity.Items.Add("ODD");
            cb_parity.Items.Add("MARK");
            cb_parity.Items.Add("SPACE");

            cb_parity.Text = "NONE";
            #endregion
        }

//=========================================================================================
//                          Conect
//==========================================================================================
        private void bt_conect_Click(object sender, EventArgs e)
        {   // verigica se apórta está aberta
            if(serialPort1.IsOpen == true)
            { // fecha a porta
                serialPort1.Close();
            }
            else
            {
                serialPort1.PortName = cb_port1.Text;
                serialPort1.BaudRate = int.Parse(cb_bould.Text);
                serialPort1.DataBits = int.Parse(cb_data.Text);
                serialPort1.StopBits = (StopBits)(cb_bits.SelectedIndex);
                serialPort1.Parity = (Parity)(cb_parity.SelectedIndex);
            }

            try
            {
                // abre a porta
                serialPort1.Open();
                bt_conect.Enabled = false; // desabilita o botão de conectar
                bt_desconect.Enabled = true;
                bt_exit.Enabled = false;
                // desabilita todos os campos enquato a comunicação estiver aberta por segurança
                cb_port1.Enabled = false;
                cb_bould.Enabled = false;
                cb_data.Enabled = false;
                cb_bits.Enabled = false;
                cb_parity.Enabled = false;
                pn_msg.BackColor = Color.Green;
                label5.ForeColor = Color.Black;
                label5.Text = "Close port";
                serialPort1.Write("P");
                timer1.Start();
            }
            catch
            {
                MessageBox.Show("ERRO de comunicação com a porta!!");
                bt_conect.Enabled = true; 
                bt_desconect.Enabled = false;
                bt_exit.Enabled = true;
                cb_port1.Enabled = true;
                cb_bould.Enabled = true;
                cb_data.Enabled = true;
                cb_bits.Enabled = true;
                cb_parity.Enabled = true;
                pn_msg.BackColor = Color.Brown;
                label5.ForeColor = Color.White;
                label5.Text = "Open port";

            }
        }// bt_conect_Click
//=========================================================================================
//                               Desconect
//=========================================================================================
        private void bt_desconect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("S");
                serialPort1.Close();
                bt_conect.Enabled = true;
                bt_desconect.Enabled = false;
                bt_exit.Enabled = true;
                cb_port1.Enabled = true;
                cb_bould.Enabled = true;
                cb_data.Enabled = true;
                cb_bits.Enabled = true;
                cb_parity.Enabled = true;
                timer1.Stop();
                pn_msg.BackColor = Color.Brown;
                label5.ForeColor = Color.White;
                label5.Text = "Open port";
                lb_sensor1.Text = "000000";
                lb_sensor2.Text = "000000";
                pn_led1.BackColor = Color.Brown;
                pn_led2.BackColor = Color.Brown;
                pn_led3.BackColor = Color.Brown;
                lb_led1.Text = "Load 1";
                lb_ld2.Text = "Load 2";
                lb_led3.Text = "Load 3";
                g_sensor1.Series[0].Points.Clear();
                g_sensor2.Series[0].Points.Clear();
                tcb_pwm.Value = 0;
                timeX1 = 0;
                timeX2 = 0;
            }
            catch
            {
                bt_conect.Enabled = false; // desabilita o botão de conectar
                bt_desconect.Enabled = true;
                bt_exit.Enabled = false;
                // desabilita todos os campos enquato a comunicação estiver aberta por segurança
                cb_port1.Enabled = false;
                cb_bould.Enabled = false;
                cb_data.Enabled = false;
                cb_bits.Enabled = false;
                cb_parity.Enabled = false;
                pn_msg.BackColor = Color.Green;
                label5.ForeColor = Color.Black;
                label5.Text = "Close port";

            }
            
        }

 //========================================================================================
 //                          Submit
 //=========================================================================================
        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                if (tb_enviar.Text != "")
                {//escreve uma string 
                    if (cb_cr.Checked)
                    {
                        serialPort1.Write(tb_enviar.Text + "\r");
                    }
                    else
                    {
                        serialPort1.Write(tb_enviar.Text);
                    }

                    tb_enviar.Text = null;
                }
                else
                {
                    MessageBox.Show("Insira dados!");
                }
            }
            else
            {
                MessageBox.Show("ERRO de comunicação com a porta!!");
            }

        }// bt_submit_Click
//=========================================================================================
//                             BUTTONS LOADS
//======================================================================================
        bool status1 = false;
        private void button1_Click(object sender, EventArgs e)
        {
            // se a porta estiver aberta    
            if (serialPort1.IsOpen == true)
            {
                if (status1 == false)
                {
                    serialPort1.Write("1");
                    pn_led1.BackColor = Color.Green;
                    pn_led1.ForeColor = Color.Black;
                    lb_led1.Text = "ON";
                    status1 = true;
                }
                else if (status1 == true)
                {
                    serialPort1.Write("2");
                    pn_led1.BackColor = Color.Brown;
                    pn_led1.ForeColor = Color.White;
                    status1 = false;
                    lb_led1.Text = "OFF";

                }
            }
        }//button1_Click

        bool status2 = false;
        private void button2_Click(object sender, EventArgs e)
        {

           
            if (serialPort1.IsOpen == true)
            {
               

                if (status2 == false)
                 {
                    serialPort1.Write("3");
                    pn_led2.BackColor = Color.Green;
                    pn_led2.ForeColor = Color.Black;
                    lb_ld2.Text = "ON";
                    status2 = true;
                    
                }
                else if (status2 == true)
                {
                    serialPort1.Write("4");
                    pn_led2.BackColor = Color.Brown;
                    pn_led2.ForeColor = Color.White;
                    lb_ld2.Text = "OFF";
                    status2 = false;

                }
                

            }
        }// button2_Click

        bool status3 = false;
        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {


                if (status3 == false)
                {
                    serialPort1.Write("5");
                    pn_led3.BackColor = Color.Green;
                    pn_led3.ForeColor = Color.Black;
                    lb_led3.Text = "ON";
                    status3 = true;

                }
                else if (status3 == true)
                {
                    serialPort1.Write("6");
                    pn_led3.BackColor = Color.Brown;
                    pn_led3.ForeColor = Color.White;
                    lb_led3.Text = "OFF";
                    status3 = false;

                }


            }

        }//  button4_Click
      
//====================================================================================
//                              PWM
//===================================================================================
        private void tcb_pwm_Scroll(object sender, EventArgs e)
        {
            
            if(serialPort1.IsOpen == true)
            {
                int valuePWM = tcb_pwm.Value * 50;
                if (valuePWM == 0 & valuePWM < 50)
                {
                    // serialPort1.Write("[PWM" + valuePWM.ToString() + "]");
                    serialPort1.Write("7");
                }
                else if (valuePWM >= 50 & valuePWM < 100)
                {
                    serialPort1.Write("8");
                   
                }
                else if (valuePWM >= 100 & valuePWM < 150)
                {
                    serialPort1.Write("9");
                }
                else if (valuePWM >= 150 & valuePWM < 200)
                {
                    serialPort1.Write("A");
                }
                else if (valuePWM >= 200 & valuePWM < 250)
                {
                    serialPort1.Write("B");
                }
                else if (valuePWM == 250)
                {
                    serialPort1.Write("C");
                }


            }
                 
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

       // 

       

        private void cb_port1_Click(object sender, EventArgs e)
        {
            cb_port1.Items.Clear();
            String[] valuesPort = SerialPort.GetPortNames();

            for (int i = 0; i < valuesPort.Length; i++)
            {
                cb_port1.Items.Add(valuesPort[i]);
            }
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            if (status == true)
            {
               
                serialPort1.Write("P");
                status = false;
            }
            else
            {
                try
                {
                    serialPort1.Write("S");
                    timer1.Stop();
                    serialPort1.Close();
                    bt_conect.Enabled = true;
                    bt_desconect.Enabled = false;
                    bt_exit.Enabled = true;
                    cb_port1.Enabled = true;
                    cb_bould.Enabled = true;
                    cb_data.Enabled = true;
                    cb_bits.Enabled = true;
                    cb_parity.Enabled = true;
                    pn_msg.BackColor = Color.Brown;
                    label5.ForeColor = Color.White;
                    label5.Text = "Open port";
                    lb_sensor1.Text = "000000";
                    lb_sensor2.Text = "000000";
                    pn_led1.BackColor = Color.Brown;
                    pn_led2.BackColor = Color.Brown;
                    pn_led3.BackColor = Color.Brown;
                    lb_led1.Text = "Load 1";
                    lb_ld2.Text = "Load 2";
                    lb_led3.Text = "Load 3";
                    lb_led1.Text = "Load 6";
                    g_sensor1.Series[0].Points.Clear();
                    g_sensor2.Series[0].Points.Clear();
                    tcb_pwm.Value = 0;

                    timeX1 = 0;
                    timeX2 = 0;
                    MessageBox.Show("Erro timer");
                }
                catch
                {
                    bt_conect.Enabled = false; // desabilita o botão de conectar
                    bt_desconect.Enabled = true;
                    bt_exit.Enabled = false;
                    // desabilita todos os campos enquato a comunicação estiver aberta por segurança
                    cb_port1.Enabled = false;
                    cb_bould.Enabled = false;
                    cb_data.Enabled = false;
                    cb_bits.Enabled = false;
                    cb_parity.Enabled = false;
                    pn_msg.BackColor = Color.Green;
                    label5.ForeColor = Color.Black;
                    label5.Text = "Close port";
                }

            }
        }

        private void bt_clean_Click(object sender, EventArgs e)
        {
            tb_reception.Text = null;
        }
    }
}
