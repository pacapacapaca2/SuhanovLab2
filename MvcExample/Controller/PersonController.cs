using MvcExample.Model;
using MvcExample.View;
using System.Windows.Forms;
namespace MvcExample.Controller
{
    public class PersonController
    {
        private MainForm view;
        public PersonController(MainForm view)
        {
            this.view = view;
            this.view.AddPerson += OnAddPerson;
        }
        private void OnAddPerson(object sender, System.EventArgs e)
        {
            string name = view.Names;
            int age = view.Age;
            Person person = new Person { Name = name, Age = age };
            view.DisplayResult($"Добавлено: {person.Name}, Возраст: {person.Age}");
        }
    }
}
