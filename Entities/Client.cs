using System;
using System.Text;

namespace ExercicioFixacao.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        public Client() 
        {
        }

        public Client(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            Date = date;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" ");
            sb.Append(Date.ToString("dd/MM/yyyy"));
            sb.Append(" - ");
            sb.AppendLine(Email);
            return sb.ToString();
        }
    }
}
