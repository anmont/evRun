using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;


namespace evrun
{
    public partial class Form1 : Form
    {
        Thread oreChecker;
        Thread enemyChecker;
        Thread actionThread;
        Thread workerChecker;
        Thread targetChecker;

        public static bool enemies = false;
        public static int enemieGoneCnt = 0;
        public static int haveEnemiesCnt = 0;
        public static int miningTargetCnt = 0;
        public static List<string> actions = new List<string>();
        public static bool checkingOre = false;
        public static bool minersInSpace = false;
        public static bool attackInSpace = false;
        public static bool hasMiningTarget = false;
        public static string log = "";
        public static bool runBot = false;
        public static bool exitApp = false;
        public static bool updatingWorkers = false;
        public static bool lastMiningStat = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void droneManager()
        {
            while (!exitApp)
            {
                bool mining = true;
                //should mining drone be out or attack drone?
                if (enemies)
                    mining = false;
                else
                {
                    mining = true;
                }

                if (lastMiningStat == mining)
                {
                    //rest and return
                    Thread.Sleep(3000);
                }
                else
                {
                    lastMiningStat = mining;

                    //determine reality
                    if (RunTest("checkMinerDrones"))
                    {
                        minersInSpace = true;
                    }

                    //match mode
                    while (mining != minersInSpace)
                    {
                        addAction("returnAllDrones");
                        //while (
                    }

                    //recall drones
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            workerChecker = new System.Threading.Thread(new System.Threading.ThreadStart(updateWorkers));
            workerChecker.Start();

            runBot = true;
            runTimer.Enabled = true;
            
            //lblHasOre.Text = RunTest("ore_full").ToString();
            //run();
            //test(@"C:\Users\anmont1\Desktop\sikuli\eve.sikuli\1417585484011.png");
        }

        public void run()
        {
            if (runBot == false)
            {
                return;
            }
            lblHasOre.Text = "Running";
            lblEnemies.Text = enemies.ToString();
            lblMinersInSpace.Text = minersInSpace.ToString();
            lblAttackDronesInSpace.Text = attackInSpace.ToString();
            lblMiningTarget.Text = hasMiningTarget.ToString();
            
            //handle ore

            

            //check for enemies
            //checkEnemies();



            //updateworkers
            if (minersInSpace == false && attackInSpace == false)
            {
                workerChecker = new System.Threading.Thread(new System.Threading.ThreadStart(updateWorkers));
                workerChecker.Start();
            }

            if (minersInSpace == true && attackInSpace == true)
            {
                workerChecker = new System.Threading.Thread(new System.Threading.ThreadStart(updateWorkers));
                workerChecker.Start();
            }

            //if no enemies and attack is in space... bring them back in
            if (enemies == false && attackInSpace == true)
            {
                addAction("returnAllDrones");
                attackInSpace = false;
            }

            if (enemies == false && attackInSpace == false && minersInSpace == false)
            {
                bool actionExists = false;

                foreach (string act in actions)
                {
                    if (act == "deployMiners")
                    {
                        actionExists = true;
                    }
                }

                if (!actionExists)
                {
                    addAction("deployMiners");
                }
                
            }

            if (enemies == false && minersInSpace == true)
            {
                if (miningTargetCnt > 3)
                {
                    miningTargetCnt = 0;
                    targetChecker = new System.Threading.Thread(new System.Threading.ThreadStart(checkTarget));
                    targetChecker.Start();
                }
                else
                {
                    miningTargetCnt++;
                }
            }
            //if (

            //lblHasOre.Text = "Done";
            rtbMessages.Text = log;
        }

        public void checkTarget()
        {
            //check idle workers

            addLog("Run Checking Targets");
            if (RunTest("idleWorkers"))
            {
                if(RunTest("hasMiningTarget"))
                {
                    //get workers back to work
                    addLog("Inactive worker Detected");
                    hasMiningTarget = true;
                    addAction("returnToWork");
                }
                else
                {
                    addLog("You have no active target");
                    hasMiningTarget = false;
                    //MessageBox.Show("Fighting Done");
                    System.Media.SystemSounds.Asterisk.Play();
                    Thread.Sleep(500);
                    System.Media.SystemSounds.Asterisk.Play();
                }
            }
        }

        public void updateWorkers()
        {
            if (!updatingWorkers)
            {
                updatingWorkers = true;
                //new thread
                addLog("Run Update Workers");
                if (RunTest("checkMinerDrones"))
                {
                    minersInSpace = true;
                }
                else
                {
                    minersInSpace = false;
                }
                if (RunTest("checkAttackDrones"))
                {
                    attackInSpace = true;
                }
                else
                {
                    attackInSpace = false;
                }
                addLog("Miners in space = " + minersInSpace.ToString() + " Attack Drones in space = " + attackInSpace.ToString());
                updatingWorkers = false;
            }
        }

        public void checkEnemies()
        {
            while (!exitApp)
            {
                if (runBot)
                {
                    //addLog("Run Check Enemies");
                    if (RunTest("check_enemy"))
                    {
                        if (haveEnemiesCnt > 1)
                        {
                            if (enemies == false)
                            {
                                addLog("You have a new enemy");
                                //we ahve a state change
                                addAction("returnAllDrones");
                                minersInSpace = false;
                                addAction("deployAttack");
                                attackInSpace = true;
                                //we still need to target and attck
                            }
                            enemies = true;
                            System.Media.SystemSounds.Beep.Play();
                            enemieGoneCnt = 0;
                        }
                        else
                        {
                            haveEnemiesCnt++;
                        }


                    }
                    else
                    {
                        if (enemieGoneCnt > 4)
                        {
                            //addLog("Your Enemy appears to be gone");
                            enemies = false;
                            enemieGoneCnt = 0;
                            haveEnemiesCnt = 0;
                        }
                        else
                        {
                            enemieGoneCnt++;
                        }
                    }
                }
                Thread.Sleep(4000);
            }

        }

        public void handleOre()
        {
            while (!exitApp)
            {
                if (runBot)
                {
                    //addLog("Run handle ore");
                    if (!checkingOre)
                    {
                        //wrapping checking ore so we arent spamming too many instances
                        checkingOre = true;
                        if (RunTest("ore_full"))
                        {
                            //ore is full... empty it.
                            addLog("Your ore is full = " + checkingOre.ToString());
                            addAction("empty_ore");
                        }
                        checkingOre = false;
                    }
                }
                Thread.Sleep(3000);
            }
            
        }

        public static bool RunTest(string sikuliTestName)
        {
            int exitCode;
            //var processInfo = new ProcessStartInfo(@"C:\Users\anmont1\Desktop\sikuli\1_1\runsikulix.cmd", "-r " + @"c:\Users\anmont1\Desktop\sikuli\eve\" + sikuliTestName + ".sikuli");
            var processInfo = new ProcessStartInfo(@"java ", "-jar " + @"C:\Users\anmont1\Desktop\sikuli\1_1\sikulix.jar -r c:\Users\anmont1\Desktop\sikuli\eve\" + sikuliTestName + ".sikuli");

            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            Process process = Process.Start(processInfo);
            process.WaitForExit();

            exitCode = process.ExitCode;
            process.Close();

            if (exitCode == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void runTimer_Tick(object sender, EventArgs e)
        {
            run();
        }

        public void addAction(string performAction)
        {
            bool dontAdd = false;
            if (actions.Count > 0)
            {
                foreach (string action in actions)
                {
                    if (performAction == action)
                    {
                        dontAdd = true;
                    }
                }
            }

            if (dontAdd == false)
            {
                actions.Add(performAction);
            }

        }

        public static void takeAction()
        {
            while (2 > 1)
            {
                if (actions.Count > 0)
                {
                    if (!RunTest(actions[0]))
                    {
                        if (enemies == true && actions[0] == "deployMiners")
                        {
                            minersInSpace = false;
                        }
                        else
                        {
                            addLog("TAKE ACTION: " + actions[0]);
                            RunTest(actions[0]);
                        }
                    }
                    actions.RemoveAt(0);

                }
                Thread.Sleep(500);
            }

        }

        public static void addLog(string message)
        {
            log = System.DateTime.Now.ToLongTimeString() + " " + message + Environment.NewLine + log;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actionThread = new System.Threading.Thread(new System.Threading.ThreadStart(takeAction));
            actionThread.Start();
            oreChecker = new System.Threading.Thread(new System.Threading.ThreadStart(handleOre));
            oreChecker.Start();
            enemyChecker = new System.Threading.Thread(new System.Threading.ThreadStart(checkEnemies));
            enemyChecker.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            runBot = false;
        }
    }
}


