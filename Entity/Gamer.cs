using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entity
{
	public class Gamer : IEntity
	{

		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int BirthYear { get; set; }
		public long IdentityNumber { get; set; }
        public object Date { get; internal set; }
        public bool TcNo { get; internal set; }
        public object DateYear { get; internal set; }
    }
}
