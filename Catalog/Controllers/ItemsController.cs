using System;
using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using System.Collections.Generic;
using Catalog.Entities;
using Catalog.DTOs;
using System.Linq;


namespace Catalog.Controllers
{
    //GET /items

    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;
        /* THIS IS WRONG -> WE NEED TO APPLY DEPENDENCY INVERSION
        public ItemsController(){
            repository = new InMemItemsRepository();
        }
        */
        public ItemsController(IItemsRepository repository){
            this.repository = repository;
        }

        //GET /items
        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            var items = repository.GetItems().Select(item => item.AsDto());
            return items;
        }

        ///GET /items/{id}
        [HttpGet("{id}")]

        ///ACTION RESULT FOR 2 TYPES OF DIFFERNTS RETURNS IN THIS CASE (STATUS AND ITEM)
        public ActionResult<ItemDto> GetItem(Guid id){
            var item = repository.GetItem(id);
            if(item is null){
                return NotFound();
            }
            return item.AsDto();
        }
    }
}