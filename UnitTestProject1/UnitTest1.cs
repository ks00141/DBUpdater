using Microsoft.VisualStudio.TestTools.UnitTesting;
using DBUpdater.Presenter;
using DBUpdater.Service;
using DBUpdater.View;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PPID조회_테스트()
        {
            //Arrange
            RecipeService service = new RecipeService();

            //Act
            int result = service.findAll().Count;

            //Assert
            Assert.AreEqual<int>(1, result);
        }

        class TestView : IRecipeList
        {
            private string[] recipeList;
            public string[] RecipeList 
            {
                get
                {
                    string[] returnValue = new string[recipeList.Length];
                    for (int i = 0; i < recipeList.Length; i++)
                    {
                        returnValue[i] = recipeList[i];
                    }
                    return returnValue;
                }
                set => recipeList = value;
            }
        }

        [TestMethod]
        public void Presenter_레시피_바인딩_테스트()
        {
            //Arrange

            TestView view = new TestView();
            RecipePresenter presenter = new RecipePresenter(view);

            //Act
            presenter.getRecipeList();

            //Assert
            foreach(string str in view.RecipeList)
            {
                System.Console.WriteLine(str);
            }
        }
    }
}
