using System.Windows.Forms;

namespace Mcba.Infraestruture
{
    public static class FormExtensions
    {
        public static DialogResult ShowMessage(this Form f, string text)
        {
            if (f == null)
            {
                return DialogResult.OK;
            }

            return ShowMessage(f, text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult ShowMessage(this Form f, string text, string caption)
        {
            if (f == null)
            {
                return DialogResult.OK;
            }

            return ShowMessage(f, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult ShowMessage(this Form f, string text, string caption, MessageBoxButtons buttons)
        {
            if (f == null)
            {
                return DialogResult.OK;
            }

            return ShowMessage(f, text, caption, buttons, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult ShowMessage(this Form f, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (f == null)
            {
                return DialogResult.OK;
            }

            return ShowMessage(f, text, caption, buttons, icon, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult ShowMessage(this Form f, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            if (f == null)
            {
                return DialogResult.OK;
            }

            return MessageBox.Show(f, text, caption, buttons, icon, defaultButton);
        }
    }
}
