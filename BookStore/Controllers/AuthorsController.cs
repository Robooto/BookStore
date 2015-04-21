using AutoMapper;
using BookStore.Contracts;
using BookStore.Datastores;
using BookStore.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStore.Controllers
{
    public class AuthorsController : ApiController
    {
        IUnitOfWork unit;

        public AuthorsController()
        {
            this.unit = new SampleDataStore();
        }

        public IHttpActionResult Get()
        {
            var result = unit.Authors.All;

            if (!result.Any())
            {
                return NotFound();
            }

            var response = result.To<AuthorDto>();

            return Ok(response);
        }
    }
}
