using System;

class Review
{
    private List<string> _prompts;
    private string _review;
    // private int _stars; ???
    public Review()
    {
        // prompts
        _review = "n/a";
    }
    public Review(string review)
    {
        // prompts
        _review = review;
    }
    public void WriteReview()
    {
        //
    }
    public void DisplayReview() // unneeded this method
    {
        // 
    }
    public string GetReview() // renamed SaveReview()
    {
        return _review;
    }
}