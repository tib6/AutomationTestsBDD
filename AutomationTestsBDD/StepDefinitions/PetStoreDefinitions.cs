using Category = AutomationTestsBDD.Models.Category;

namespace AutomationTestsBDD.StepDefinitions
{
    [Binding]
    public sealed class PetStoreDefinitions
    {
        enum Status
        {
            available,
            pending,
            sold
        }

        string tst_name = "Tstname";
        PetStoreBody getBody;

        [Given(@"Pet (.*) added")]
        public void AddPetId(int id)
        {
            var category = new Category()
            {
                id = 1,
                name = "Test",
            };

            List<string> photoList = new List<string>();
            photoList.Add("url1");
            photoList.Add("url2");

            var tag1 = new Tag()
            {
                id = 1,
                name = "Tag1",
            };
            var tag2 = new Tag()
            {
                id = 2,
                name = "Tag2",
            };

            List<Tag> tags = new List<Tag>();
            tags.Add(tag1);
            tags.Add(tag2);

            var body = new PetStoreBody()
            {
                id = id,
                category = category,
                name = tst_name,
                photoUrls = photoList,
                tags = tags,
                status = Status.available.ToString()
            };

            var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            var uri = new Uri($"{TestSettings.petStoreBaseURL}{TestSettings.addPet}");
            var response = HttpClientBasic.SendPostAsync<PetStoreBody>(uri, content).Result;
            Assert.Multiple(() =>
            {
                Assert.That(response.id, Is.EqualTo(id));
                Assert.That(response.category.name, Is.EqualTo(category.name));
                Assert.That(response.name, Is.EqualTo(tst_name));
                Assert.That(response.photoUrls[0], Is.EqualTo(photoList[0]));
                Assert.That(response.tags[0].name, Is.EqualTo(tag1.name));
                Assert.That(response.status, Is.EqualTo(Status.available.ToString()));
            });
            Console.WriteLine("Pet added Succesfully!");
        }

        [When(@"Pet (.*) is modified")]
        public void ModifyPet(int id)
        {
            var category = new Category()
            {
                id = 1,
                name = "Test_Updated",
            };

            List<string> photoList = new List<string>();
            photoList.Add("url1");
            photoList.Add("url2");

            var tag1 = new Tag()
            {
                id = 1,
                name = "update",
            };
            var tag2 = new Tag()
            {
                id = 2,
                name = "update",
            };

            List<Tag> tags = new List<Tag>();
            tags.Add(tag1);
            tags.Add(tag2);

            var body = new PetStoreBody()
            {
                id = id,
                category = category,
                name = tst_name,
                photoUrls = photoList,
                tags = tags,
                status = Status.sold.ToString()
            };

            var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            var uri = new Uri($"{TestSettings.petStoreBaseURL}{TestSettings.updatePet}");
            var response = HttpClientBasic.SendPutAsync<PetStoreBody>(uri, content).Result;
            Assert.Multiple(() =>
            {
                Assert.That(response.id, Is.EqualTo(id));
                Assert.That(response.category.name, Is.EqualTo(category.name));
                Assert.That(response.name, Is.EqualTo(tst_name));
                Assert.That(response.photoUrls[0], Is.EqualTo(photoList[0]));
                Assert.That(response.tags[0].name, Is.EqualTo(tag1.name));
                Assert.That(response.status, Is.EqualTo(Status.sold.ToString()));
            });
            Console.WriteLine("Pet modified Succesfully!");
        }

        [When(@"Pet (.*) is deleted")]
        public void DeletePet(int id)
        {
            var uri = new Uri($"{TestSettings.petStoreBaseURL}{TestSettings.getPet}{id}");
            var response = HttpClientBasic.SendGetAsync<PetStoreBody>(uri).Result;
            Assert.Multiple(() =>
            {
                Assert.That(response.id, Is.EqualTo(id));
                Assert.That(response.name, Is.EqualTo(tst_name));
                Assert.That(response.status, Is.EqualTo(Status.sold.ToString()));
            });
            Console.WriteLine("Get Pet Succesfully!");

            var deleteUri = new Uri($"{TestSettings.petStoreBaseURL}{TestSettings.deletePet}{id}");
            var deleteResponse = HttpClientBasic.SendDeleteAsync<DeletePetResponse>(uri).Result;
            Assert.Multiple(() =>
            {
                Assert.That(deleteResponse.code, Is.EqualTo((int)HttpStatusCode.OK));
                Assert.That(deleteResponse.message, Is.EqualTo(id.ToString()));
            });
            Console.WriteLine("Pet Deleted Succesfully!");

        }

        [Then(@"Pet (.*) is cleared")]
        public void CheckPetIsDeleted(int id)
        {
            var uri = new Uri($"{TestSettings.petStoreBaseURL}{TestSettings.getPet}{id}");
            var response = HttpClientBasic.SendGetAsync<GetDeletedPetResponse>(uri, HttpStatusCode.NotFound).Result;
            Assert.Multiple(() =>
            {
                Assert.That(response.code, Is.EqualTo(1));
                Assert.That(response.type, Is.EqualTo("error"));
                Assert.That(response.message, Is.EqualTo("Pet not found"));
            });
            Console.WriteLine("Check Pet was Deleted Succesfully!");
        }
    }
}