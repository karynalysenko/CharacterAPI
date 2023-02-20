using AutoMapper;
using MyWebApplication.Dtos.Character;
using MyWebApplication.Dtos.Skill;

namespace MyWebApplication
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();

        }
    }
}
