using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archi.Librairy.Models;
using System.Collections;

namespace Archi.Library.Controllers
{
    public abstract class BaseController<TContext, TModel> : ControllerBase where TContext : DbContext where TModel : ModelBase
    {
        protected readonly TContext _context;

        public BaseController(TContext context)
        {
            _context = context;
        }

        //// GET: api/{model}
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<TModel>>> GetAll()
        //{
        //    return await _context.Set<TModel>().Where(x => x.Active == true).ToListAsync();
        //    //return await _context.Pizzas.Where(x => x.Active == true).ToListAsync();
        //}

        //// GET: api/Customers/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<TModel>> GetId(int id)
        //{
        //    var ModelId = await _context.Set<TModel>().FindAsync(id);

        //    if (ModelId == null && ModelId.Active == false)
        //    {
        //        return NotFound("hello");
        //    }

        //    return ModelId;
        //}

        //// POST: api/Customers
        //[HttpPost]
        //public async Task<ActionResult<TModel>> PostModel(TModel model)
        //{
        //    _context.Set<TModel>().Add(model);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCustomer", new { id = model.ID }, model);
        //}



    }

}