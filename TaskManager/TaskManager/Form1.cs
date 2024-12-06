using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializePriorityComboBox();
            LoadProcesses();
        }

        private void InitializePriorityComboBox()
        {
            cb_priority.DataSource = Enum.GetValues(typeof(ProcessPriorityClass));
            cb_priority.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LoadProcesses()
        {
            try
            {
                var processes = Process.GetProcesses().OrderBy(p => p.ProcessName).ToList();
                dataGridView.Rows.Clear();

                foreach (var process in processes)
                {
                    AddProcessToGrid(process);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading processes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProcessToGrid(Process process)
        {
            try
            {
                dataGridView.Rows.Add(
                    process.Id,
                    process.ProcessName,
                    process.WorkingSet64 / 1024,
                    process.BasePriority,
                    process.Threads.Count,
                    process.StartTime
                );
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error adding process {process.ProcessName}: {ex.Message}");
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog
            {
                Title = "Select a file to run",
                Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StartFile(openFileDialog.FileName);
                }
            }
        }

        private void StartFile(string filePath)
        {
            try
            {
                Process.Start(filePath);
                MessageBox.Show($"File '{filePath}' has been started.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (TryGetSelectedProcess(out var process))
            {
                KillProcess(process);
            }
        }

        private void KillProcess(Process process)
        {
            try
            {
                process.Kill();
                MessageBox.Show($"Process '{process.ProcessName}' has been terminated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProcesses();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error terminating process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



       

        private ProcessPriorityClass GetNewPriority(ProcessPriorityClass currentPriority, bool increase)
        {
            if (increase)
            {
                if (currentPriority == ProcessPriorityClass.Idle)
                    return ProcessPriorityClass.BelowNormal;
                else if (currentPriority == ProcessPriorityClass.BelowNormal)
                    return ProcessPriorityClass.Normal;
                else if (currentPriority == ProcessPriorityClass.Normal)
                    return ProcessPriorityClass.AboveNormal;
                else if (currentPriority == ProcessPriorityClass.AboveNormal)
                    return ProcessPriorityClass.RealTime;
                else if (currentPriority == ProcessPriorityClass.RealTime)
                    return ProcessPriorityClass.RealTime; 
            }
            else
            {
                if (currentPriority == ProcessPriorityClass.RealTime)
                    return ProcessPriorityClass.AboveNormal;
                else if (currentPriority == ProcessPriorityClass.AboveNormal)
                    return ProcessPriorityClass.Normal;
                else if (currentPriority == ProcessPriorityClass.Normal)
                    return ProcessPriorityClass.BelowNormal;
                else if (currentPriority == ProcessPriorityClass.BelowNormal)
                    return ProcessPriorityClass.Idle;
                else if (currentPriority == ProcessPriorityClass.Idle)
                    return ProcessPriorityClass.Idle; 
            }

            return currentPriority;
        }

        private bool TryGetSelectedProcess(out Process process)
        {
            process = null;
            if (dataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    int processId = (int)dataGridView.SelectedRows[0].Cells["ColumnId"].Value;
                    process = Process.GetProcessById(processId);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a process.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return false;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    int processId = (int)dataGridView.SelectedRows[0].Cells["ColumnId"].Value;
                    ProcessPriorityClass newPriority = (ProcessPriorityClass)cb_priority.SelectedItem;

                    Process process = Process.GetProcessById(processId);
                    process.PriorityClass = newPriority;

                    MessageBox.Show($"Priority of process {process.ProcessName} has been changed to {newPriority}.");
                    LoadProcesses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error changing priority: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a process to change its priority.");
            }
        }
    }
}
