using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
  using DATA.Reponstories;
  using DATA.IReponstories;
  using DATA.Models;
  using DATA.DbContext;
  [Route("api/[controller]")]
  [ApiController]
  public class AdsController : ControllerBase
  {
    private readonly IReponstories<Ad> _IReponstories;
    private readonly DbContextBlog _context = new DbContextBlog();
    public AdsController()
    {
      var reponsitories = new Reponstories<Ad>(_context, _context.Ad);
      this._IReponstories = reponsitories;
    }
    //create
    [HttpPost("create-ad")]
    public string CreateAd(string name, int status, string url)
    {
      //check trung ten neu ton tai tra ve thong bao sai
      if (_IReponstories.GetAll().Any(p => p.Name == name))
      {
        return "Name is exist";
      }
      var ad = new Ad()
      {
        Id = Guid.NewGuid(),
        Name = name,
        Status = status,
        Url = url
      };
      return _IReponstories.Create(ad);
    }
    //update
    [HttpPut("update-ad")]
    public string UpdateAd(Guid id, string name, int status, string url)
    {
      var adUpdate = _IReponstories.GetAll().FirstOrDefault(p => p.Id == id);
      if (adUpdate == null)
      {
        return "Id is not exist";
      }
      adUpdate.Name = name;
      adUpdate.Status = status;
      adUpdate.Url = url;
      return _IReponstories.Update(adUpdate);
    }
    //delete
    [HttpDelete("delete-ad")]
    public string DeleteAd(Guid id)
    {
      var adDelete = _IReponstories.GetAll().FirstOrDefault(p => p.Id == id);
      if (adDelete == null)
      {
        return "Id is not exist";
      }
      return _IReponstories.Delete(adDelete);
    }
    //get all
    [HttpGet("get-all-ad")]
    public IEnumerable<Ad> GetAllAd()
    {
      return _IReponstories.GetAll();
    }
    //get by id
    [HttpGet("get-by-id-ad")]
    public Ad GetByIdAd(Guid id)
    {
      return _IReponstories.GetByID(id);
    }
    //get by name
    [HttpGet("get-by-name-ad")]
    public IEnumerable<Ad> GetByNameAd(string name)
    {
      return _IReponstories.GetByName(name);
    }
    //delete many
    [HttpDelete("delete-many-ad")]
    public string DeleteManyAd(List<Guid> idAdList)
    {
      var listAd = new List<Ad>();
      foreach (var id in idAdList)
      {
        var adDelete = _IReponstories.GetAll().FirstOrDefault(p => p.Id == id);
        if (adDelete == null)
        {
          return "Id is not exist";
        }
        listAd.Add(adDelete);
      }
      return _IReponstories.DeleteMany(listAd);
    }
  }
}
