using System;
using HelloBlazor.Shared;
namespace HelloBlazor.Server.Repositories
{
	public interface IBikeRepository
	{
		BEBike[] GetAll();
		void Add(BEBike bike);
		void DeleteById(int id);
	}
}

