using MyWebApplication.Dtos.Character;
using MyWebApplication.Dtos.Weapon;

namespace MyWebApplication.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}
