using AutoMapper;

namespace Procuerment.Pofiles
{
    public class ProcuermentProfile : AutoMapper.Profile
    {
        public ProcuermentProfile()
        {
            CreateMap<Dtos.ProcuermentReadDto, Models.Procurement>();

        }

    }
}


