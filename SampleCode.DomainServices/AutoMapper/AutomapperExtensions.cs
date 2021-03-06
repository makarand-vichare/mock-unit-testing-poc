﻿using AutoMapper;
using SampleCode.Models;
using SampleCode.ViewModels;
using System.Collections.Generic;

namespace SampleCode.DomainServices.AutoMapper
{
    public static class AutomapperExtensions
    {
        public static VM ToViewModel<T, VM>(this T model)
        {
            return Mapper.Map<T, VM>(model);
        }

        public static T ToEntityModel<T, VM>(this VM viewModel)
        {
            return Mapper.Map<VM, T>(viewModel);
        }

        public static VM ToViewModel<VM>(this BaseModel entity) where VM : BaseViewModel
        {
            return (VM)Mapper.Map(entity, entity.GetType(), typeof(VM));
        }

        public static T ToEntityModel<T>(this BaseViewModel entity) where T : BaseModel
        {
            return (T)Mapper.Map(entity, entity.GetType(), typeof(T));
        }

        public static IEnumerable<VM> ToViewModel<T, VM>(this IEnumerable<T> models)
        {
            return Mapper.Map<IEnumerable<T>, IEnumerable<VM>>(models);
        }

        public static IEnumerable<T> ToEntityModel<T, VM>(this IEnumerable<VM> viewModels)
        {
            return Mapper.Map<IEnumerable<VM>, IEnumerable<T>>(viewModels);
        }

        public static List<VM> ToViewModel<VM>(this IEnumerable<BaseModel> entity) where VM : BaseViewModel
        {
            return (List<VM>)Mapper.Map(entity, entity.GetType(), typeof(VM));
        }

        public static List<T> ToEntityModel<T>(this IEnumerable<BaseViewModel> entity) where T : BaseModel
        {
            return (List<T>)Mapper.Map(entity, entity.GetType(), typeof(T));
        }

    }
}
