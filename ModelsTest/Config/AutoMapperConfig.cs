using AutoMapper;
using ModelsTest.DTO;
using ModelsTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsTest.Config
{
    /// <summary>
    /// AutoMapper's Global Entity Mapping Configuration Static Class
    /// </summary>
    public static class AutoMapperConfiguration
    {
        public static void Init()
        {
            MapperConfiguration = new MapperConfiguration(cfg =>
            {

                #region Account

                cfg.CreateMap<Account, AccountDTO>();     
                cfg.CreateMap<AccountDTO, Account>();
                cfg.CreateMap<CreateAccountInput, Account>();

                #endregion
            });

            Mapper = MapperConfiguration.CreateMapper();
        }

        public static IMapper Mapper { get; private set; }

        public static MapperConfiguration MapperConfiguration { get; private set; }
    }

    /// <summary>
    /// AutoMapper initialization class
    /// </summary>
    public class AutoMapperStartupTask
    {
        public void Execute()
        {
            AutoMapperConfiguration.Init();
        }
    }

    /// <summary>
    /// Static Extended Classes for Database Table-Entity Mapping
    /// </summary>
    public static class MappingExtensions
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            return AutoMapperConfiguration.Mapper.Map<TSource, TDestination>(source);
        }

        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return AutoMapperConfiguration.Mapper.Map(source, destination);
        }

        #region Post
      /*  public static PostViewModel ToModel(this Post entity)
        {
            return entity.MapTo<Post, PostViewModel>();
        }

        public static Post ToEntity(this PostViewModel model)
        {
            return model.MapTo<PostViewModel, Post>();
        }*/

        #endregion

    }
}