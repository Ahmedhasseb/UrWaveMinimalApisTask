using CloudinaryDotNet.Actions;

namespace UrWave.Featuers.Product.Interface
{
    public interface IPhoto
    {
       
        public Task DeletionPhotoAsync(string publicid);
        public Task<string> UploadImageAsync(IFormFile file);
    }
}
