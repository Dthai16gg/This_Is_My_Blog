

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace API.Controllers;

using DATA.DbContext;
using DATA.IReponstories;
using DATA.Models;
using DATA.Reponstories;

using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AdsController : ControllerBase
{
  private readonly DbContextBlog _context = new();

  private readonly IReponstories<Ad> _IReponstories;

  public AdsController()
  {
    var reponsitories = new Reponstories<Ad>(this._context, this._context.Ad);
    this._IReponstories = reponsitories;
  }

  // create
  [HttpPost("create-ad")]
  public string CreateAd(string name, int status, string url)
  {
    // check trung ten neu ton tai tra ve thong bao sai
    if (this._IReponstories.GetAll().Any(p => p.Name == name)) return "Name is exist";
    var ad = new Ad();
    ad.Id = Guid.NewGuid();
    ad.Name = name;
    ad.Status = status;
    ad.Url = url;
    return this._IReponstories.Create(ad);
  }

  // delete
  [HttpDelete("delete-ad")]
  public string DeleteAd(Guid id)
  {
    var adDelete = this._IReponstories.GetAll().FirstOrDefault(p => p.Id == id);
    if (adDelete == null) return "Id is not exist";
    return this._IReponstories.Delete(adDelete);
  }

  // delete many
  [HttpDelete("delete-many-ad")]
  public string DeleteManyAd(List<Guid> idAdList)
  {
    var listAd = new List<Ad>();
    foreach (var id in idAdList)
    {
      var adDelete = this._IReponstories.GetAll().FirstOrDefault(p => p.Id == id);
      if (adDelete == null) return "Id is not exist";
      listAd.Add(adDelete);
    }

    return this._IReponstories.DeleteMany(listAd);
  }

  // get all
  [HttpGet("get-all-ad")]
  public IEnumerable<Ad> GetAllAd()
  {
    return this._IReponstories.GetAll();
  }

  // get by id
  [HttpGet("get-by-id-ad")]
  public Ad GetByIdAd(Guid id)
  {
    return this._IReponstories.GetByID(id);
  }

  // get by name
  [HttpGet("get-by-name-ad")]
  public IEnumerable<Ad> GetByNameAd(string name)
  {
    return this._IReponstories.GetByName(name);
  }

  // update
  [HttpPut("update-ad")]
  public string UpdateAd(Guid id, string name, int status, string url)
  {
    var adUpdate = this._IReponstories.GetAll().FirstOrDefault(p => p.Id == id);
    if (adUpdate == null) return "Id is not exist";
    adUpdate.Name = name;
    adUpdate.Status = status;
    adUpdate.Url = url;
    return this._IReponstories.Update(adUpdate);
  }
}
