using System.Collections.Generic;
using System.Windows.Forms;
using Mcba.Dal;
using Mcba.Infraestruture.Settings;

namespace Mcba.Bll.Helpers
{
    public static class CaptionHelper
    {
        public static string GetCaption(string module, string tag)
        {
            return new CaptionDal(McbaSettings.CnnString).GetCaption((int)McbaSettings.Language, module, tag);
        }

        public static Dictionary<string, string> GetCaptions(string module)
        {
            return new CaptionDal(McbaSettings.CnnString).GetCaptions((int)McbaSettings.Language, module);
        }

        public static void SetCaptions(Dictionary<string, string> captions, Form form)
        {
            if(form.Tag != null && captions.TryGetValue(form.Tag.ToString(), out var title))
            {
                form.Text = title;
            }

            foreach (Control control in form.Controls)
            {
                if (control.Tag != null && captions.TryGetValue(control.Tag.ToString(), out var caption))
                {
                    control.Text = caption;
                }

                if (control.Controls.Count > 0)
                {
                    SetCaptions(captions, control.Controls);
                }

                if (control is MenuStrip menuStrip)
                {
                    SetCaptions(captions, menuStrip);
                }

                if (control is ToolStrip toolStrip)
                {
                    SetCaptions(captions, toolStrip);
                }
            }
        }

        private static void SetCaptions(Dictionary<string, string> captions, ToolStrip toolStrip)
        {
            foreach (ToolStripItem stripItem in toolStrip.Items)
            {
                if (stripItem.Tag != null && captions.TryGetValue(stripItem.Tag.ToString(), out var caption))
                {
                    stripItem.Text = caption;
                }
            }
        }

        public static void SetCaptions(Dictionary<string, string> captions, Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Tag != null && captions.TryGetValue(control.Tag.ToString(), out var caption))
                {
                    control.Text = caption;
                }

                if (control.Controls.Count > 0)
                {
                    SetCaptions(captions, control.Controls);
                }

                if (control is MenuStrip menuStrip)
                {
                    SetCaptions(captions, menuStrip);
                }

                if (control is ToolStrip toolStrip)
                {
                    SetCaptions(captions, toolStrip);
                }
            }
        }

        private static void SetCaptions(Dictionary<string, string> captions, MenuStrip menu)
        {
            foreach (ToolStripMenuItem menuItem in menu.Items)
            {
                if (menuItem.Tag != null && captions.TryGetValue(menuItem.Tag.ToString(), out var caption))
                {
                    menuItem.Text = caption;
                }

                if (menuItem.DropDownItems.Count > 0)
                {
                    SetCaptions(captions, menuItem.DropDownItems);
                }
            }
        }

        private static void SetCaptions(Dictionary<string, string> captions, ToolStripItemCollection menuItems)
        {
            foreach (ToolStripMenuItem menuItem in menuItems)
            {
                if (menuItem.Tag != null && captions.TryGetValue(menuItem.Tag.ToString(), out var caption))
                {
                    menuItem.Text = caption;
                }

                if (menuItem.DropDownItems.Count > 0)
                {
                    SetCaptions(captions, menuItem.DropDownItems);
                }
            }
        }

        public static void SetCaption(ToolStripStatusLabel tsLabel, string module, string tag)
        {
            tsLabel.Text = GetCaption(module, tag);
        }
    }
}
