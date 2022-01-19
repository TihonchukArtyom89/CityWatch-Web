using CityWatch.Api.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityWatch.Api
{
    public class ControllerImplementationFacade : IController
    {
        public Task<Response15> ActiveAsync(long contractorId, long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<Response10> ActiveRequestsAsync(long problemCategoryId, long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<Response3> AddressAsync(Body7 body)
        {
            throw new NotImplementedException();
        }

        public Task<Response14> ArchiveAsync(long contractorId, long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<Response12> ArchiveRequestsAsync(long problemCategoryId, long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<User> BlockedAsync(long userId)
        {
            throw new NotImplementedException();
        }

        public Task<Response11> CompletedRequestsAsync(long problemCategoryId, long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<Contractor> ContractorsDELETEAsync(long contractorId)
        {
            throw new NotImplementedException();
        }

        public Task<Response16> ContractorsGET2Async(long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<Contractor> ContractorsGETAsync(long contractorId)
        {
            throw new NotImplementedException();
        }

        public Task<Contractor> ContractorsPOSTAsync(ContractorForm body)
        {
            throw new NotImplementedException();
        }

        public Task<Contractor> ContractorsPUTAsync(long contractorId, ContractorForm body)
        {
            throw new NotImplementedException();
        }

        public Task<Response4> CoordsAsync(Body8 body)
        {
            throw new NotImplementedException();
        }

        public Task<FileResult> ExportAsync(Body11 body)
        {
            throw new NotImplementedException();
        }

        public Task HandlerAsync(long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<Response6> HeatmapAsync(Body10 body)
        {
            throw new NotImplementedException();
        }

        public Task ImportAsync(IEnumerable<FileParameter> filenames)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Request>> InRangeAsync(Body13 body)
        {
            throw new NotImplementedException();
        }

        public Task<Response> LoginAsync(Body2 body)
        {
            throw new NotImplementedException();
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MailingQuery> MailingDELETEAsync(long mailingId)
        {
            throw new NotImplementedException();
        }

        public Task<Response19> MailingGET2Async(long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<MailingQuery> MailingGETAsync(long mailingId)
        {
            throw new NotImplementedException();
        }

        public Task<MailingQuery> MailingPOST2Async(MailingQueryForm body)
        {
            throw new NotImplementedException();
        }

        public Task MailingPOSTAsync(MailingBody body)
        {
            throw new NotImplementedException();
        }

        public Task<MailingQuery> MailingPUTAsync(long mailingId, MailingQueryForm body)
        {
            throw new NotImplementedException();
        }

        public Task<User> MeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FileResult> PdfAsync(long requestId)
        {
            throw new NotImplementedException();
        }

        public Task<ProblemCategory> ProblemCategoriesDELETEAsync(long problemCategoryId)
        {
            throw new NotImplementedException();
        }

        public Task<Response9> ProblemCategoriesGET2Async(long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<User> ProblemCategoriesGETAsync(long problemCategoryId)
        {
            throw new NotImplementedException();
        }

        public Task<ProblemCategory> ProblemCategoriesPOSTAsync(ProblemCategoryForm body)
        {
            throw new NotImplementedException();
        }

        public Task<ProblemCategory> ProblemCategoriesPUTAsync(long problemCategoryId, ProblemCategoryForm body)
        {
            throw new NotImplementedException();
        }

        public Task<Profile> ProfileAsync(long userId)
        {
            throw new NotImplementedException();
        }

        public Task<Profile> ProfilesDELETEAsync(long profileId)
        {
            throw new NotImplementedException();
        }

        public Task<Response8> ProfilesGET2Async(long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<Profile> ProfilesGETAsync(long profileId)
        {
            throw new NotImplementedException();
        }

        public Task<Profile> ProfilesPOSTAsync(ProfileForm body)
        {
            throw new NotImplementedException();
        }

        public Task<Profile> ProfilesPUTAsync(long profileId, ProfileForm body)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Request>> RatingAsync(Body14 body)
        {
            throw new NotImplementedException();
        }

        public Task<Response2> RefreshtokenAsync(Body3 body)
        {
            throw new NotImplementedException();
        }

        public Task<Region> RegionsDELETEAsync(long regionId)
        {
            throw new NotImplementedException();
        }

        public Task<Response22> RegionsGET2Async(long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<Region> RegionsGETAsync(long regionId)
        {
            throw new NotImplementedException();
        }

        public Task<Region> RegionsPOSTAsync(RegionForm body)
        {
            throw new NotImplementedException();
        }

        public Task<Region> RegionsPUTAsync(long regionId, RegionForm body)
        {
            throw new NotImplementedException();
        }

        public Task<Request> RequestsDELETEAsync(long requestId)
        {
            throw new NotImplementedException();
        }

        public Task<Response13> RequestsGET2Async(long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<Request> RequestsGETAsync(long requestId)
        {
            throw new NotImplementedException();
        }

        public Task<Request> RequestsPOSTAsync(IFormFile body)
        {
            throw new NotImplementedException();
        }

        public Task<Request> RequestsPUTAsync(long requestId, IFormFile body)
        {
            throw new NotImplementedException();
        }

        public Task ResetAsync(Body4 body)
        {
            throw new NotImplementedException();
        }

        public Task<Role> RolesDELETEAsync(long roleId)
        {
            throw new NotImplementedException();
        }

        public Task<Response18> RolesGET2Async(long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<Role> RolesGETAsync(long roleId)
        {
            throw new NotImplementedException();
        }

        public Task<Role> RolesPOSTAsync(RoleForm body)
        {
            throw new NotImplementedException();
        }

        public Task<Role> RolesPUT2Async(long roleId, RoleForm body)
        {
            throw new NotImplementedException();
        }

        public Task<User> RolesPUTAsync(long userId, Body12 body)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Body5 body)
        {
            throw new NotImplementedException();
        }

        public Task SignupAsync(Body body)
        {
            throw new NotImplementedException();
        }

        public Task<Response5> StatisticAsync(Body9 body)
        {
            throw new NotImplementedException();
        }

        public Task<StoredRequest> StoredRequestsDELETEAsync(long storedRequestId)
        {
            throw new NotImplementedException();
        }

        public Task<Response17> StoredRequestsGET2Async(long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<StoredRequest> StoredRequestsGETAsync(long storedRequestId)
        {
            throw new NotImplementedException();
        }

        public Task<StoredRequest> StoredRequestsPOSTAsync(StoredRequestForm body)
        {
            throw new NotImplementedException();
        }

        public Task<StoredRequest> StoredRequestsPUTAsync(long storedRequestId, StoredRequestForm body)
        {
            throw new NotImplementedException();
        }

        public Task<Role> StoriesDELETEAsync(long storyId)
        {
            throw new NotImplementedException();
        }

        public Task<Response21> StoriesGET2Async(long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<Story> StoriesGETAsync(long storyId)
        {
            throw new NotImplementedException();
        }

        public Task<Story> StoriesPOSTAsync(StoryForm body)
        {
            throw new NotImplementedException();
        }

        public Task<Story> StoriesPUTAsync(long storyId, StoryForm body)
        {
            throw new NotImplementedException();
        }

        public Task<ContractorTask> TasksDELETEAsync(long taskId)
        {
            throw new NotImplementedException();
        }

        public Task<ContractorTask> TasksGET2Async(long taskId)
        {
            throw new NotImplementedException();
        }

        public Task<Response20> TasksGET3Async(long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<ContractorTask> TasksGETAsync(long contractorId)
        {
            throw new NotImplementedException();
        }

        public Task<ContractorTask> TasksPOSTAsync(ContractorTaskForm body)
        {
            throw new NotImplementedException();
        }

        public Task<ContractorTask> TasksPUTAsync(long taskId, ContractorTaskForm body)
        {
            throw new NotImplementedException();
        }

        public Task<User> UnblockedAsync(long userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Body6 body)
        {
            throw new NotImplementedException();
        }

        public Task<User> UsersDELETEAsync(long userId)
        {
            throw new NotImplementedException();
        }

        public Task<Response7> UsersGET2Async(long? page, long? size)
        {
            throw new NotImplementedException();
        }

        public Task<User> UsersGETAsync(long userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> UsersPOSTAsync(UserForm body)
        {
            throw new NotImplementedException();
        }

        public Task<User> UsersPUTAsync(long userId, UserForm body)
        {
            throw new NotImplementedException();
        }

        public Task Watch2Async(long storyId)
        {
            throw new NotImplementedException();
        }

        public Task WatchAsync(long requestId)
        {
            throw new NotImplementedException();
        }
    }
}
