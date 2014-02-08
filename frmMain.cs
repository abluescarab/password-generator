using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO: Add an icon

namespace password_generator {
	public partial class frmMain : Form {
		public frmMain() {
			InitializeComponent();
		}

		#region Form
		private void frmMain_Load(object sender, EventArgs e) {
			if(Properties.Settings.Default.firstRun) {
				txtSaveLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\passwords.txt";
				Properties.Settings.Default.saveLocation = txtSaveLocation.Text;
			}

			tmrClearStatus.Enabled = true;

			if(Properties.Settings.Default.saveFile) {
				btnSave.Enabled = true;
				chkMassGen.Enabled = true;
			}
			else {
				btnSave.Enabled = false;
				chkMassGen.Enabled = false;
			}

			if(Properties.Settings.Default.massGen) {
				numMassGen.Enabled = true;
			}
			else {
				numMassGen.Enabled = false;
			}

			Properties.Settings.Default.firstRun = false;
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
			Properties.Settings.Default.Save();
		}
		#endregion

		#region Main
		private void btnGenerate_Click(object sender, EventArgs e) {
			Cursor.Current = Cursors.WaitCursor;

			Random rand = new Random();
			string result;
			bool failed = false;

			if(Properties.Settings.Default.saveFile) {
				using(StreamWriter file = new StreamWriter(txtSaveLocation.Text, true)) {
					if(Properties.Settings.Default.massGen) {
						int amount = Convert.ToInt32(numMassGen.Value);

						while(0 < amount--) {
							result = Generate(rand);

							if(result != "failed") {
								file.WriteLine(result);
							}
							else {
								UpdateStatus("Not enough options selected for this length.");
								failed = true;
								break;
							}
						}

						if(!failed) {
							UpdateStatus("Finished generating and saving " + numMassGen.Value + " passwords.");
						}
					}
					else {
						result = Generate(rand);

						if(result != "failed") {
							txtPassword.Text = result;

							file.WriteLine(txtPassword.Text);

							UpdateStatus("Finished generating and saving password.");
						}
						else {
							UpdateStatus("Not enough options selected for this length.");
							failed = true;
						}
					}
				}
			}
			else {
				result = Generate(rand);

				if(result != "failed") {
					txtPassword.Text = result;

					UpdateStatus("Finished generating password.");
				}
				else {
					UpdateStatus("Not enough options selected for this length.");
					failed = true;
				}

			}

			Cursor.Current = Cursors.Default;
		}

		private void btnCopy_Click(object sender, EventArgs e) {
			CopyToClipboard();
		}

		private void flgSave_FileOk(object sender, CancelEventArgs e) {
			txtSaveLocation.Text = flgSave.FileName;
		}

		private void tmrClearStatus_Tick(object sender, EventArgs e) {
			UpdateStatus("");
			tmrClearStatus.Enabled = false;
		}
		#endregion

		#region General Options
		private void chkRepeat_CheckedChanged(object sender, EventArgs e) {
			Properties.Settings.Default.charRepeat = chkRepeat.Checked;
		}

		private void chkUppercase_CheckedChanged(object sender, EventArgs e) {
			Properties.Settings.Default.charUppercase = chkUppercase.Checked;
		}

		private void chkLowercase_CheckedChanged(object sender, EventArgs e) {
			Properties.Settings.Default.charLowercase = chkLowercase.Checked;
		}

		private void chkNumbers_CheckedChanged(object sender, EventArgs e) {
			Properties.Settings.Default.charNumbers = chkNumbers.Checked;
		}

		private void chkHyphen_CheckedChanged(object sender, EventArgs e) {
			Properties.Settings.Default.charHyphen = chkHyphen.Checked;
		}

		private void chkUnderscore_CheckedChanged(object sender, EventArgs e) {
			Properties.Settings.Default.charUnderscore = chkUnderscore.Checked;
		}

		private void chkSpace_CheckedChanged(object sender, EventArgs e) {
			Properties.Settings.Default.charSpace = chkSpace.Checked;
		}

		private void chkSpecial_CheckedChanged(object sender, EventArgs e) {
			Properties.Settings.Default.charSpecial = chkSpecial.Checked;
		}

		private void chkBrackets_CheckedChanged(object sender, EventArgs e) {
			Properties.Settings.Default.charBrackets = chkBrackets.Checked;
		}

		private void numLength_ValueChanged(object sender, EventArgs e) {
			Properties.Settings.Default.passLength = numLength.Value;
		}
		#endregion

		#region Save File Options
		private void chkSave_CheckedChanged(object sender, EventArgs e) {
			Properties.Settings.Default.saveFile = chkSave.Checked;

			if(Properties.Settings.Default.saveFile) {
				btnSave.Enabled = true;
				chkMassGen.Enabled = true;
			}
			else {
				btnSave.Enabled = false;
				chkMassGen.Enabled = false;

				if(chkMassGen.Checked) {
					chkMassGen.Checked = false;
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e) {
			flgSave.ShowDialog();
		}
		#endregion

		#region Mass Generation Options
		private void chkMassGen_CheckedChanged(object sender, EventArgs e) {
			Properties.Settings.Default.massGen = chkMassGen.Checked;

			if(Properties.Settings.Default.massGen) {
				numMassGen.Enabled = true;
			}
			else {
				numMassGen.Enabled = false;
			}
		}

		private void numMassGen_ValueChanged(object sender, EventArgs e) {
			Properties.Settings.Default.massAmount = numMassGen.Value;
		}
		#endregion

		#region Menu
		private void fileExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void editCopy_Click(object sender, EventArgs e) {
			CopyToClipboard();
		}
		private void helpAbluescarab_Click(object sender, EventArgs e) {
			Process.Start("http://www.abluescarab.us/");
		}

		private void helpGithub_Click(object sender, EventArgs e) {
			Process.Start("https://github.com/abluescarab/password-generator/releases");
		}

		private void helpChangelog_Click(object sender, EventArgs e) {
			Process.Start(Application.StartupPath + "/Resources/changelog.txt");
		}

		private void helpHelp_Click(object sender, EventArgs e) {
			Process.Start(Application.StartupPath + "/Resources/Password Generator Help.html");
		}

		private void helpAbout_Click(object sender, EventArgs e) {
			frmAbout frmAbout = new frmAbout();

			frmAbout.ShowDialog();
		}
		#endregion

		#region Functions
		private string Generate(Random rand) {
			string sAll = "", result = "", sLower, sUpper, sNumbers, sHyphen, sUnderscore, sSpace, sSpecial, sBrackets;
			int length = Convert.ToInt32(numLength.Value);
			char character;

			sLower = "abcdefghijklmnopqrstuvwxyz";
			sUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			sNumbers = "0123456789";
			sHyphen = "-";
			sUnderscore = "_";
			sSpace = " ";
			sSpecial = "`~!@#$%^&*()+=\\|/?.,;:'\"";
			sBrackets = "()[]{}<>";

			if(Properties.Settings.Default.charUppercase)
				sAll += sUpper;
			if(Properties.Settings.Default.charLowercase)
				sAll += sLower;
			if(Properties.Settings.Default.charNumbers)
				sAll += sNumbers;
			if(Properties.Settings.Default.charHyphen)
				sAll += sHyphen;
			if(Properties.Settings.Default.charUnderscore)
				sAll += sUnderscore;
			if(Properties.Settings.Default.charSpace)
				sAll += sSpace;
			if(Properties.Settings.Default.charSpecial)
				sAll += sSpecial;
			if(Properties.Settings.Default.charBrackets)
				sAll += sBrackets;

			while(0 < length--) {
				if(sAll.Length == 0) {
					return "failed";
				}
				
				character = sAll[rand.Next(sAll.Length)];

				if(chkRepeat.Checked == true) {
					sAll = sAll.Remove(sAll.IndexOf(character), 1);
				}

				result += character;
			}

			return result;
		}

		private void CopyToClipboard() {
			if(txtPassword.Text != "") {
				Clipboard.SetText(txtPassword.Text);
				UpdateStatus("Password copied to clipboard.");
			}
			else {
				UpdateStatus("Nothing to copy.");
			}
		}

		private void UpdateStatus(string text) {
			if(tmrClearStatus.Enabled == true) {
				tmrClearStatus.Enabled = false;
			}

			statusText.Text = text;
			tmrClearStatus.Enabled = true;
		}
		#endregion
	}
}
