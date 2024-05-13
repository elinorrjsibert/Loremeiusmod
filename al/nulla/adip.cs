try
{
    // Initialize the HttpWebRequest and set any properties here
    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://example.com");

    // Asynchronously get the response
    using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
    {
        // Check the response status code
        if (response.StatusCode == HttpStatusCode.OK)
        {
            // Process the response stream
            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    string responseText = await reader.ReadToEndAsync();
                    // Do something with the responseText
                }
            }
        }
        else
        {
            // Handle error response
        }
    }
}
catch (WebException ex)
{
    // Handle web exception (e.g., network error, no server response)
}
catch (Exception ex)
{
    // Handle other exceptions that may occur
}
