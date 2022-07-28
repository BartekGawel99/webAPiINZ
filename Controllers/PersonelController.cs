using Microsoft.AspNetCore.Mvc;
using webAPiINZ.Data;
using webAPiINZ.Model;

namespace webAPiINZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonelController : Controller
    {
        private readonly InżContext _context;

        public PersonelController(InżContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("PersonalSave")]
        public async Task<ActionResult<bool>> Personal(Personal personel)
        {

            Personal personal = new Personal()
            {
                IdUser = personel.IdUser,
                Mass = personel.Mass,
                Height = personel.Height,
                Gender = personel.Gender,
                Age = personel.Age,
                Pal = personel.Pal,
                Target = personel.Target,
                CPM = personel.CPM,
                Protein = personel.Protein,
                Carbonates = personel.Carbonates,
                Fat = personel.Fat,
                CPMTarget = personel.CPMTarget,
                IdealBodyMass = personel.IdealBodyMass,
                ProteinPer = personel.ProteinPer,
                CarbonatesPer = personel.CarbonatesPer,
                FatPer = personel.FatPer,
                SaveTime = personel.SaveTime,
            };
            try
            {
                _context.Personals.Add(personal);
                await _context.SaveChangesAsync();
                return Ok(true);
            } catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("Personal/{idUser}")]
        public List<Personal> PersonalLoad(Guid idUser)
        {

            List<Personal> personal = new List<Personal>();
            personal = _context.Personals.Where(id => id.IdUser == idUser).ToList();
            return personal;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var personal = _context.Personals.Find(id);
            if (personal == null)
                return BadRequest();

            _context.Personals.Remove(personal);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public void UpdatePersonal(int id, Personal personel)
        {
            var entity = _context.Personals.FirstOrDefault(e => e.Id == id);
            if (entity == null)
                return;

            entity.IdUser = personel.IdUser;
            entity.Mass = personel.Mass;
            entity.Height = personel.Height;
            entity.Gender = personel.Gender;
            entity.Age = personel.Age;
            entity.Pal = personel.Pal;
            entity.Target = personel.Target;
            entity.CPM = personel.CPM;
            entity.Protein = personel.Protein;
            entity.Carbonates = personel.Carbonates;
            entity.Fat = personel.Fat;
            entity.CPMTarget = personel.CPMTarget;
            entity.IdealBodyMass = personel.IdealBodyMass;
            entity.ProteinPer = personel.ProteinPer;
            entity.CarbonatesPer = personel.CarbonatesPer;
            entity.FatPer = personel.FatPer;
            entity.SaveTime = personel.SaveTime;

            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
