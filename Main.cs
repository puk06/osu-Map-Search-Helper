using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace osu_search_filter_generator
{
    public partial class Main : Form
    {
        private string[] _modeValue = Array.Empty<string>();
        private string[] _keysValue = Array.Empty<string>();
        private string[] _statusValue = Array.Empty<string>();
        private string[][] _value = Array.Empty<string[]>();

        public Main()
        {
            InitializeComponent();
            MODE_OSU.CheckedChanged += Mode_CheckedChanged;
            MODE_TAIKO.CheckedChanged += Mode_CheckedChanged;
            MODE_CATCH.CheckedChanged += Mode_CheckedChanged;
            MODE_MANIA.CheckedChanged += Mode_CheckedChanged;

            STATUS_RANKED.CheckedChanged += STATUS_CheckedChanged;
            STATUS_LOVED.CheckedChanged += STATUS_CheckedChanged;
            STATUS_APPROVED.CheckedChanged += STATUS_CheckedChanged;
            STATUS_PENDING.CheckedChanged += STATUS_CheckedChanged;
            STATUS_NOTSUBMITTED.CheckedChanged += STATUS_CheckedChanged;
            STATUS_EXCLUDEAPPROVED.CheckedChanged += STATUS_CheckedChanged;

            MANIA_1K.CheckedChanged += Keys_CheckedChanged;
            MANIA_2K.CheckedChanged += Keys_CheckedChanged;
            MANIA_3K.CheckedChanged += Keys_CheckedChanged;
            MANIA_4K.CheckedChanged += Keys_CheckedChanged;
            MANIA_5K.CheckedChanged += Keys_CheckedChanged;
            MANIA_6K.CheckedChanged += Keys_CheckedChanged;
            MANIA_7K.CheckedChanged += Keys_CheckedChanged;
            MANIA_8K.CheckedChanged += Keys_CheckedChanged;
            MANIA_9K.CheckedChanged += Keys_CheckedChanged;
            MANIA_10K.CheckedChanged += Keys_CheckedChanged;
        }

        private void ReloadPreview()
        {
            var values = new List<string>();
            values.AddRange(_modeValue);
            values.AddRange(_keysValue);
            values.AddRange(_statusValue);
            values.AddRange(_value.Select(item => item[0] + item[1] + item[2]));
            PREVIEW_LABEL.Text = string.Join("\n", values);
        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            switch (KEY_COMBOBOX.Text)
            {
                case "Keys":
                    UpdateKeysValue();
                    ReloadPreview();
                    return;
                case "Status":
                    UpdateStatusValue();
                    ReloadPreview();
                    return;
            }

            switch (KEY_COMBOBOX.Text)
            {
                case "AR":
                case "CS":
                case "OD":
                case "HP":
                case "Length":
                case "Stars":
                case "BPM":
                case "Drain":
                case "Speed":
                case "Played":
                case "UnPlayed":
                    if (!double.TryParse(VALUE_TEXTBOX.Text, out _))
                    {
                        MessageBox.Show("数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }

            foreach (var item in _value)
            {
                var key = item[0];
                var operation = item[1];
                if (key != KEY_COMBOBOX.Text) continue;

                var oppositeOperations = new Dictionary<string, string[]>
                {
                    { "<", new[] { ">", ">=" } },
                    { ">", new[] { "<", "<=" } },
                    { "<=", new[] { ">", ">=" } },
                    { ">=", new[] { "<", "<=" } }
                };

                if (oppositeOperations.ContainsKey(operation) && oppositeOperations[operation].Contains(OPERATION_COMBOBOX.Text))
                {
                    _value = _value.Append(new[] { KEY_COMBOBOX.Text, OPERATION_COMBOBOX.Text, VALUE_TEXTBOX.Text }).ToArray();
                    ReloadPreview();
                    return;
                }

                _value = _value.Where(x => x != item).ToArray();
                _value = _value.Append(new[] { KEY_COMBOBOX.Text, OPERATION_COMBOBOX.Text, VALUE_TEXTBOX.Text }).ToArray();
                ReloadPreview();
                return;
            }

            _value = _value.Append(new[] { KEY_COMBOBOX.Text, OPERATION_COMBOBOX.Text, VALUE_TEXTBOX.Text }).ToArray();

            ReloadPreview();
        }

        private void KEY_COMBOBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (KEY_COMBOBOX.Text)
            {

                case "Status":
                    OPERATION_COMBOBOX.Visible = false;
                    VALUE_TEXTBOX.Visible = false;
                    STATUS_RANKED.Visible = true;
                    STATUS_LOVED.Visible = true;
                    STATUS_APPROVED.Visible = true;
                    STATUS_PENDING.Visible = true;
                    STATUS_NOTSUBMITTED.Visible = true;
                    MANIA_1K.Visible = false;
                    MANIA_2K.Visible = false;
                    MANIA_3K.Visible = false;
                    MANIA_4K.Visible = false;
                    MANIA_5K.Visible = false;
                    MANIA_6K.Visible = false;
                    MANIA_7K.Visible = false;
                    MANIA_8K.Visible = false;
                    MANIA_9K.Visible = false;
                    MANIA_10K.Visible = false;
                    ADD_BUTTON.Visible = false;
                    break;

                case "AR":
                    case "CS":
                        case "OD":
                            case "HP":
                                case "Length":
                                    case "Stars":
                                        case "BPM":
                                            case "Drain":
                                                case "Played":
                                                    case "UnPlayed":
                                                        case "Speed":
                                                            case "Artist":
                                                                case "Creator":
                    OPERATION_COMBOBOX.Visible = true;
                    OPERATION_COMBOBOX.SelectedIndex = 0;
                    VALUE_TEXTBOX.Visible = true;
                    STATUS_RANKED.Visible = false;
                    STATUS_LOVED.Visible = false;
                    STATUS_APPROVED.Visible = false;
                    STATUS_PENDING.Visible = false;
                    STATUS_NOTSUBMITTED.Visible = false;
                    STATUS_EXCLUDEAPPROVED.Visible = false;
                    MANIA_1K.Visible = false;
                    MANIA_2K.Visible = false;
                    MANIA_3K.Visible = false;
                    MANIA_4K.Visible = false;
                    MANIA_5K.Visible = false;
                    MANIA_6K.Visible = false;
                    MANIA_7K.Visible = false;
                    MANIA_8K.Visible = false;
                    MANIA_9K.Visible = false;
                    MANIA_10K.Visible = false;
                    ADD_BUTTON.Visible = true;
                    break;

                case "Keys":
                    OPERATION_COMBOBOX.Visible = false;
                    VALUE_TEXTBOX.Visible = false;
                    MANIA_1K.Visible = true;
                    MANIA_2K.Visible = true;
                    MANIA_3K.Visible = true;
                    MANIA_4K.Visible = true;
                    MANIA_5K.Visible = true;
                    MANIA_6K.Visible = true;
                    MANIA_7K.Visible = true;
                    MANIA_8K.Visible = true;
                    MANIA_9K.Visible = true;
                    MANIA_10K.Visible = true;
                    STATUS_RANKED.Visible = false;
                    STATUS_LOVED.Visible = false;
                    STATUS_APPROVED.Visible = false;
                    STATUS_PENDING.Visible = false;
                    STATUS_NOTSUBMITTED.Visible = false;
                    STATUS_EXCLUDEAPPROVED.Visible = false;
                    ADD_BUTTON.Visible = false;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KEY_COMBOBOX.SelectedIndex = 0;
        }

        private void STATUS_RANKED_CheckedChanged(object sender, EventArgs e)
        {
            STATUS_EXCLUDEAPPROVED.Checked = false;
            STATUS_EXCLUDEAPPROVED.Visible = STATUS_RANKED.Checked;
        }

        private void Mode_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox)) return;
            UpdateModeValue();
            ReloadPreview();
        }

        private void STATUS_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox)) return;
            UpdateStatusValue();
            ReloadPreview();
        }

        private void Keys_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox)) return;
            UpdateKeysValue();
            ReloadPreview();
        }

        private void UpdateModeValue()
        {
            _modeValue = Array.Empty<string>();
            var checkedModes = new List<string>();
            string[] modes = { "o", "t", "c", "m" };

            if (MODE_OSU.Checked) checkedModes.Add("o");
            if (MODE_TAIKO.Checked) checkedModes.Add("t");
            if (MODE_CATCH.Checked) checkedModes.Add("c");
            if (MODE_MANIA.Checked) checkedModes.Add("m");

            switch (checkedModes.Count)
            {
                case 0:
                    _modeValue = Array.Empty<string>();
                    break;
                case 1:
                    _modeValue = new[] { $"Mode={checkedModes[0]}" };
                    break;
                default:
                {
                    modes = modes.Except(checkedModes).ToArray();
                    foreach (var mode in modes)
                    {
                        _modeValue = _modeValue.Append($"Mode!={mode}").ToArray();
                    }
                    break;
                }
            }

            ReloadPreview();
        }

        private void UpdateKeysValue()
        {
            _keysValue = Array.Empty<string>();
            var checkedKeys = new List<string>();
            string[] keys = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            if (MANIA_1K.Checked) checkedKeys.Add("1");
            if (MANIA_2K.Checked) checkedKeys.Add("2");
            if (MANIA_3K.Checked) checkedKeys.Add("3");
            if (MANIA_4K.Checked) checkedKeys.Add("4");
            if (MANIA_5K.Checked) checkedKeys.Add("5");
            if (MANIA_6K.Checked) checkedKeys.Add("6");
            if (MANIA_7K.Checked) checkedKeys.Add("7");
            if (MANIA_8K.Checked) checkedKeys.Add("8");
            if (MANIA_9K.Checked) checkedKeys.Add("9");
            if (MANIA_10K.Checked) checkedKeys.Add("10");

            switch (checkedKeys.Count)
            {
                case 0:
                    _keysValue = Array.Empty<string>();
                    break;
                case 1:
                    _keysValue = new[] { $"Keys={checkedKeys[0]}" };
                    break;
                default:
                {
                    keys = keys.Except(checkedKeys).ToArray();
                    foreach (var key in keys)
                    {
                        _keysValue = _keysValue.Append($"Keys!={key}").ToArray();
                    }
                    break;
                }
            }
        }

        private void UpdateStatusValue()
        {
            _statusValue = Array.Empty<string>();
            var checkedStatus = new List<string>();
            string[] status = { "Ranked", "Loved", "Approved", "Pending", "NotSubmitted" };

            if (STATUS_RANKED.Checked) checkedStatus.Add("Ranked");
            if (STATUS_APPROVED.Checked) checkedStatus.Add("Approved");
            if (STATUS_LOVED.Checked) checkedStatus.Add("Loved");
            if (STATUS_PENDING.Checked) checkedStatus.Add("Pending");
            if (STATUS_NOTSUBMITTED.Checked) checkedStatus.Add("NotSubmitted");

            if (STATUS_APPROVED.Checked && !STATUS_RANKED.Checked && checkedStatus.Count > 1)
            {
                MessageBox.Show("ApprovedとRanked以外のStatusは組み合わせることが出来ないため、Rankedが自動的に有効になります。", "組み合わせエラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                STATUS_RANKED.Checked = true;
                return;
            }

            switch (checkedStatus.Count)
            {
                case 0:
                    _statusValue = Array.Empty<string>();
                    break;
                case 1:
                    _statusValue = new[] { $"Status={checkedStatus[0]}" };
                    break;
                default:
                {
                    status = status.Except(checkedStatus).ToArray();
                    foreach (var key in status)
                    {
                        _statusValue = _statusValue.Append($"Status!={key}").ToArray();
                    }
                    break;
                }
            }

            if (STATUS_EXCLUDEAPPROVED.Checked && !_statusValue.Contains("Status!=Approved"))
            {
                _statusValue = _statusValue.Append("Status!=Approved").ToArray();
            }
        }

        private void STATUS_EXCLUDEAPPROVED_CheckedChanged(object sender, EventArgs e)
        {
            if (STATUS_EXCLUDEAPPROVED.Checked) STATUS_APPROVED.Checked = false;
        }

        private void STATUS_APPROVED_CheckedChanged(object sender, EventArgs e)
        {
            if (STATUS_APPROVED.Checked) STATUS_EXCLUDEAPPROVED.Checked = false;
        }

        private void COPY_BUTTON_Click(object sender, EventArgs e)
        {
            var values = new List<string>();
            values.AddRange(_modeValue);
            values.AddRange(_keysValue);
            values.AddRange(_statusValue);
            values.AddRange(_value.Select(item => item[0] + item[1] + item[2]));
            if (values.Count == 0)
            {
                MessageBox.Show("条件を追加してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Clipboard.SetText(string.Join(" ", values));
            MessageBox.Show("クリップボードにコピーしました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
