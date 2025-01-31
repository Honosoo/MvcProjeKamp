﻿using System.Collections.Generic;
using BusinessLayer.Utilities.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Web;
using EntityLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;


namespace MvcProjeKamp.Models
{
    /// <summary>  
    /// Image view model class.  
    /// </summary>  
    public class ImageViewModel
    {
        

        [Required]
        [Display(Name = "Upload File")]
        [AllowFileSize(FileSize = 5 * 1024 * 1024, ErrorMessage = "İzin verilen dosya boyutu : 5 MB")]
        [AllowExtensions(Extensions = "png,jpg,jpeg,gif,PNG,JPG,JPEG,GIF", ErrorMessage = "Desteklenen dosya uzantıları :  .png | .jpg | .jpeg | .gif")] 
        public HttpPostedFileBase FileAttach { get; set; }

        public string Message { get; set; }

        public bool IsValid { get; set; }

       

      



        
    }
}