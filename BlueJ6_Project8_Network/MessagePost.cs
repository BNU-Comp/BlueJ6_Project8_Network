using System;
using System.Collections.Generic;


namespace BlueJ6_Project8_Network
{
    /**
     * This class stores information about a post in a social network. 
     * The main part of the post consists of a (possibly multi-line)
     * text message. Other data, such as author and time, are also stored.
     * 
     * @author Michael Kölling and David J. Barnes
     * @version 0.1
     */
    public class MessagePost
    {
        private String username;  // username of the post's author
        private String message;   // an arbitrarily long, multi-line message
        private long timestamp;
        private int likes;
        private List<String> comments;

        /**
         * Constructor for objects of class MessagePost.
         * 
         * @param author    The username of the author of this post.
         * @param text      The text of this post.
         */
        public MessagePost(String author, String text)
        {
            username = author;
            message = text;
            timestamp = DateTime.Now.Millisecond;
            likes = 0;
            comments = new List<String>();
        }

        /**
         * Record one more 'Like' indication from a user.
         */
        public void Like()
        {
            likes++;
        }

        /**
         * Record that a user has withdrawn his/her 'Like' vote.
         */
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        /**
         * Add a comment to this post.
         * 
         * @param text  The new comment to add.
         */
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        /**
         * Return the text of this post.
         * 
         * @return The post's text.
         */
        public String GetText()
        {
            return message;
        }

        /**
         * Return the time of creation of this post.
         * 
         * @return The post's creation time, as a system time value.
         */
        public long GetTimeStamp()
        {
            return timestamp;
        }

        /**
         * Display the details of this post.
         * 
         * (Currently: Print to the text terminal. This is simulating display 
         * in a web browser for now.)
         */
        public void Display()
        {
            Console.WriteLine(username);
            Console.WriteLine(message);
            Console.Write(TimeString(timestamp));

            if (likes > 0)
            {
                Console.WriteLine("  -  " + likes + " people like this.");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("   No comments.");
            }
            else
            {
                Console.WriteLine("   " + comments.Count + " comment(s). Click here to view.");
            }
        }

        /**
         * Create a string describing a time point in the past in terms 
         * relative to current time, such as "30 seconds ago" or "7 minutes ago".
         * Currently, only seconds and minutes are used for the string.
         * 
         * @param time  The time value to convert (in system milliseconds)
         * @return      A relative time string for the given time
         */

        private String TimeString(long time)
        {
            long current = DateTime.Now.Millisecond;
            long pastMillis = current - time;      // time passed in milliseconds
            long seconds = pastMillis / 1000;
            long minutes = seconds / 60;
            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }
}
