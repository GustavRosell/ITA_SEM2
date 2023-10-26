using System;
using modul14.Shared;
namespace modul14.Server.Repositories
{
	public interface IBikeRepository
	{
		BEBike[] GetAll();
		void Add(BEBike bike);
		void DeleteById(int id);
	}
}

