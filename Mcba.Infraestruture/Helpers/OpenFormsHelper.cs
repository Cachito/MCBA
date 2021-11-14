using System.Linq;
using System.Windows.Forms;

namespace Mcba.Infraestruture.Helpers
{
    public static class OpenFormsHelper
    {
        public static bool CheckIfFormIsOpen(string formName)
        {
            var formOpen = Application.OpenForms.Cast<Form>().Any(form => form.Name == formName);

            return formOpen;
        }

        public static Form GetOpened(string formName)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(x => x.Name == formName);
        }
    }
}