using System;
using System.Collections.Generic;


namespace BlueJ6_Project8_Network
{
    /**
     * The NewsFeed class stores news posts for the news feed in a social network 
     * application.
     * 
     * Display of the posts is currently simulated by printing the details to the
     * terminal. (Later, this should display in a browser.)
     * 
     * This version does not save the data to disk, and it does not provide any
     * search or ordering functions.
     * 
     * @author Michael Kölling and David J. Barnes
     * @version 0.1
     */
    public class NewsFeed
    {
        private List<MessagePost> messages;
        private List<PhotoPost> photos;

        /**
         * Construct an empty news feed.
         */
        public NewsFeed()
        {
            messages = new List<MessagePost>();
            photos = new List<PhotoPost>();
        }

        /**
         * Add a text post to the news feed.
         * 
         * @param text  The text post to be added.
         */
        public void AddMessagePost(MessagePost message)
        {
            messages.Add(message);
        }

        /**
         * Add a photo post to the news feed.
         * 
         * @param photo  The photo post to be added.
         */
        public void AddPhotoPost(PhotoPost photo)
        {
            photos.Add(photo);
        }

        /**
         * Show the news feed. Currently: print the news feed details to the
         * terminal. (To do: replace this later with display in web browser.)
         */
        public void Show()
        {
            // display all text posts
            foreach (MessagePost message in messages)
            {
                message.Display();
                Console.WriteLine();   // empty line between posts
            }

            // display all photos
            foreach (PhotoPost photo in photos)
            {
                photo.Display();
                Console.WriteLine();   // empty line between posts
            }
        }
    }
}
