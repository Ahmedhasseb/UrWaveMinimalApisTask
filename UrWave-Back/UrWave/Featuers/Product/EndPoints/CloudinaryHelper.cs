using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using UrWave.Featuers.Product.Interface;

namespace UrWave.Featuers.Product.EndPoints
{
    public class CloudinaryHelper:IPhoto
    {
        private readonly Cloudinary _cloudinary;
        private readonly IConfiguration _config;
        public CloudinaryHelper(IConfiguration config)
        {
            _config = config;
            var acc = new Account(
                config["CloudinarySettings:CloudName"],
                config["CloudinarySettings:ApiKey"],
                config["CloudinarySettings:ApiSecret"]);
            _cloudinary = new Cloudinary(acc);
        }
        

        public async Task DeletionPhotoAsync(string publicid)
        {
            var deletionParams = new DeletionParams(publicid);
            await _cloudinary.DestroyAsync(deletionParams);
        }
        public async Task<string> UploadImageAsync(IFormFile file)
        {
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(file.FileName, file.OpenReadStream()),
                Transformation = new Transformation().Height(200).Width(130).Crop("fill").Gravity("auto")
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);
            return uploadResult.SecureUrl.AbsoluteUri;
        }
    }
}

