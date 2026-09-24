<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>HTML Form Example</title>
</head>
<body>

    <h1>HTML Form Example</h1>
    <p>This is an example of an HTML4 <u>HTML5</u> form containing various input controls:</p>

    <form>
        <!-- User Information Section -->
        <fieldset>
            <legend>User Information</legend>
            <p>
                <label for="username">Username:</label>
                <input type="text" id="username" name="username">
            </p>
            <p>
                <label for="email">Email:</label>
                <input type="email" id="email" name="email">
            </p>
            <p>
                <label for="password">Password:</label>
                <input type="password" id="password" name="password">
            </p>
        </fieldset>

        <!-- Contact Information Section -->
        <fieldset>
            <legend>Contact Information</legend>
            <p>
                <label for="phone">Phone:</label>
                <input type="tel" id="phone" name="phone">
            </p>
            <p>
                <label for="message">Message:</label><br>
                <textarea id="message" name="message" rows="4" cols="50"></textarea>
            </p>
        </fieldset>

        <!-- Subscription Section -->
        <fieldset>
            <legend>Subscription</legend>
            <p>
                <label>
                    Subscribe to newsletter: <input type="checkbox" name="subscribe1">
                </label>
            </p>
            <p>
                <label>
                    Subscribe to newsletter: <input type="checkbox" name="subscribe2">
                </label>
            </p>
        </fieldset>

        <!-- Preferred Language Section -->
        <fieldset>
            <legend>Preferred Language</legend>
            <p>
                <label for="language">Select your preferred language:</label>
                <select id="language" name="language">
                    <option value="english">English</option>
                    <option value="spanish">Spanish</option>
                    <option value="french">French</option>
                    <option value="german">German</option>
                </select>
            </p>
        </fieldset>

        <!-- Feedback Section -->
        <fieldset>
            <legend>Feedback</legend>
            <p>
                <label for="rate">Rate our service:</label>
                <input type="range" id="rate" name="rate">
            </p>
        </fieldset>

        <br>
        <!-- Form Buttons -->
        <input type="submit" value="Submit">
        <input type="reset" value="Reset">
    </form>

</body>
</html>


