using System;
using System.Collections.Generic;
using System.Linq;

namespace CyberSecurityChatbotGUI // IMPORTANT: Ensure this namespace matches your project's namespace
{
    public class ChatbotResponses
    {
        private readonly Random _random = new Random();

        private readonly Dictionary<string, List<string>> _responses = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
        {
            { "password safety overview", new List<string> { "Password safety is paramount for protecting your online accounts. Always use strong, unique passwords and consider using a password manager.", "For robust password safety, combine uppercase and lowercase letters, numbers, and symbols, and aim for a length of at least 12 characters." } },
            { "phishing overview", new List<string> { "Phishing is a deceptive cyberattack designed to trick you into revealing sensitive information. Always be suspicious of unexpected emails or messages.", "To avoid phishing, verify the sender's legitimacy, never click suspicious links, and be cautious about unsolicited requests for personal data." } },
            { "safe browse overview", new List<string> { "Safe Browse involves practices that minimize security risks while using the internet. Always check for HTTPS and be wary of untrusted downloads.", "To ensure safe Browse, keep your browser and extensions updated, and only download from reputable sources." } },
            { "malware overview", new List<string> { "Malware is malicious software designed to harm your computer systems, including viruses, ransomware, and spyware. Antivirus software is essential.", "Protecting against malware involves keeping your software updated, using reliable antivirus, and exercising caution with online downloads and links." } },
            { "social engineering overview", new List<string> { "Social engineering is the art of manipulating people to give up confidential information or perform actions. It exploits human psychology.", "To avoid social engineering, be skeptical of unsolicited requests, always verify identities, and be cautious about sharing personal information." } },
            { "data privacy overview", new List<string> { "Data privacy is about your right to control how your personal information is collected, used, and shared. Understanding privacy policies is key.", "To enhance data privacy, read privacy policies carefully, be mindful of what you share online, and utilize privacy-enhancing tools." } },
            { "network security overview", new List<string> { "Network security protects your network and data from unauthorized access and threats. Strong Wi-Fi passwords and firewalls are fundamental.", "To improve network security, use strong encryption (WPA3) for Wi-Fi, enable a firewall, and consider using a VPN for secure connections." } },
            { "incident response overview", new List<string> { "Incident response is the systematic process of handling and recovering from security breaches to minimize their impact. Having a plan is vital.", "To effectively manage security incidents, have a clear response plan, ensure employees are trained, and regularly update your security measures." } },
            { "name_set", new List<string> { "Nice to meet you, {0}! I'm here to help you with cybersecurity awareness.", "Hello {0}! I'm glad you're here to learn about cybersecurity." } },
            { "positive_feedback", new List<string> { "I'm glad to hear that, {0}! Let's continue with your cybersecurity learning.", "That's wonderful, {0}! How can I help you with cybersecurity today?" } },
            { "negative_feedback", new List<string> { "I understand your concern, {0}. Let me help you with your cybersecurity questions.", "Don't worry, {0}. I'm here to help you navigate cybersecurity challenges." } },
            { "what makes a strong password?", new List<string> { "A strong password uses a mix of uppercase and lowercase letters, numbers, and symbols and is at least 12 characters long." } },
            { "how can i create a strong password?", new List<string> { "Combine uppercase and lowercase letters, numbers, and special symbols. Aim for a length of 12 or more characters." } },
            { "what is password strength?", new List<string> { "Password strength refers to how resistant a password is to guessing or cracking attempts." } },
            { "is it safe to reuse passwords?", new List<string> { "No, it's not safe. Reusing passwords means if one account is compromised, others are also vulnerable." } },
            { "should i use a password manager?", new List<string> { "Yes, a password manager can generate and securely store complex passwords for all your accounts." } },
            { "what is two factor authentication?", new List<string> { "Two-factor authentication adds an extra security layer requiring a second verification method besides your password." } },
            { "how does biometric authentication work?", new List<string> { "Biometric authentication uses unique biological traits like fingerprints or facial scans to verify your identity." } },
            { "what is multi-factor authentication", new List<string> { "Multi-factor authentication (MFA) requires two or more verification factors to gain access to an account." } },
            { "what are common password mistakes", new List<string> { "Common mistakes include using easily guessable words, birthdates, or common patterns." } },
            { "how to avoid password issues", new List<string> { "Use a password manager, enable multi-factor authentication, and avoid reusing passwords." } },
            { "what is password theft", new List<string> { "Password theft refers to the unauthorized acquisition of your passwords, often through methods like phishing or malware." } },
            { "what is phishing?", new List<string> { "Phishing is a type of online fraud where attackers try to trick you into revealing personal information via deceptive emails or websites." } },
            { "what is a suspicious email?", new List<string> { "A suspicious email often asks for personal information, contains unexpected attachments, or urges immediate action." } },
            { "what are the signs of a phishing email?", new List<string> { "Look for suspicious sender addresses, generic greetings, urgent requests, typos, and mismatched links." } },
            { "how can i avoid phishing attacks?", new List<string> {"Be cautious of unsolicited emails, don't click suspicious links, and verify sender legitimacy.",
                                                                 "Always double-check the sender's email address and look for any inconsistencies.",
                                                                 "Never provide personal information, such as passwords or credit card details, via email."} },
            { "what should i do if i clicked a phishing link?", new List<string> { "Immediately change your passwords and notify the affected service provider." } },
            { "what is spear phishing?", new List<string> { "Spear phishing is a targeted phishing attack aimed at a specific individual or organization." } },
            { "what is whaling attack", new List<string> { "Whaling attacks target high-profile executives or individuals." } },
            { "what is vishing", new List<string> { "Vishing uses phone calls to trick people into divulging private information." } },
            { "how to avoid phishing", new List<string> { "Verify sender legitimacy, don't click on suspicious links, and be cautious of unsolicited emails." } },
            { "what is safe browse?", new List<string> { "Safe Browse involves practices that minimize security risks while using the internet, like checking for HTTPS." } },
            { "how can i ensure website security?", new List<string> { "Look for 'HTTPS' and the padlock icon. Be cautious on unfamiliar sites and avoid untrusted downloads." } },
            { "is http secure to use?", new List<string> { "No, HTTP is not secure. Always use websites with 'HTTPS'." } },
            { "what does https mean?", new List<string> { "HTTPS indicates a secure connection where communication between your browser and the website is encrypted." } },
            { "is it safe to download from unknown sites?", new List<string> { "No, downloading from unknown sites can expose you to malware." } },
            { "what about browser extension security?", new List<string> { "Only install extensions from trusted sources and review their permissions carefully." } },
            { "what is a zero-day exploit?", new List<string> { "A zero-day exploit targets a software vulnerability that is unknown to the vendor." } },
            { "how to check if a website is secure", new List<string> { "Check for HTTPS, a padlock icon, and look at the site's security certificate." } },
            { "how to avoid browse issues", new List<string> {"Use strong, unique passwords for all your online accounts.",
                                                              "Enable two-factor authentication whenever possible.",
                                                              "Keep your browser and operating system up to date."} },
            { "what is malware?", new List<string> { "Malware is software designed to harm your computer systems, including viruses, worms, ransomware, and spyware." } },
            { "what is a computer virus?", new List<string> { "A virus is malware that attaches to other programs and spreads when those programs are executed." } },
            { "what is ransomware?", new List<string> { "Ransomware encrypts your files and demands payment to restore them. Paying is generally not recommended." } },
            { "what is spyware?", new List<string> { "Spyware secretly monitors your computer activity and collects personal data." } },
            { "how can i protect against malware?", new List<string> { "Keep your software updated, use antivirus software, and be cautious online." } },
            { "what is antivirus software?", new List<string> { "Antivirus software helps detect and remove malware. Keep it updated." } },
            { "what is a firewall?", new List<string> { "A firewall controls network traffic to prevent unauthorized access." } },
            { "what is a trojan horse?", new List<string> { "A Trojan horse is malware disguised as legitimate software, tricking users into installing it." } },
            { "what is a worm?", new List<string> { "A worm is a standalone malware computer program that replicates itself in order to spread to other computers." } },
            { "what is adware?", new List<string> { "Adware is software that automatically displays or downloads unwanted advertisements when a user is online." } },
            { "how to remove malware", new List<string> { "Use reputable antivirus software to scan and remove malware. In severe cases, professional help might be needed." } },
            { "what are the signs of malware infection", new List<string> { "Slow performance, frequent crashes, pop-up ads, and suspicious network activity can indicate malware." } },
            { "what is social engineering?", new List<string> { "Social engineering is the psychological manipulation of people into performing actions or divulging confidential information." } },
            { "how does social engineering work?", new List<string> { "Attackers exploit human trust, curiosity, or fear to trick individuals into compromising security." } },
            { "what is baiting?", new List<string> { "Baiting involves offering something enticing (like a free download) to trick victims into installing malware or providing info." } } ,
            { "what is pretexting?", new List<string> { "Pretexting involves creating a fabricated scenario (a 'pretext') to trick a victim into giving up sensitive information." } },
            { "what is quid pro quo?", new List<string> { "Quid pro quo attacks offer a service or benefit in exchange for information, like offering 'technical support' for login credentials." } },
            { "how to defend against social engineering?", new List<string> { "Be skeptical of unsolicited requests, verify identities, and practice strong cybersecurity awareness." } },
            { "what is tailgating?", new List<string> { "Tailgating is when an unauthorized person follows an authorized person into a restricted area." } },
            { "what is shoulder surfing?", new List<string> { "Shoulder surfing involves directly observing someone's sensitive information (like a PIN or password) as they enter it." } },
            { "what is data privacy?", new List<string> { "Data privacy is the right of individuals to control their personal information and how it is collected, used, and shared." } },
            { "why is data privacy important?", new List<string> { "It protects individuals from misuse of their data, identity theft, and unauthorized surveillance." } },
            { "what are privacy settings?", new List<string> { "Privacy settings on social media and other platforms allow you to control who can see your information." } },
            { "how can i protect my personal data?", new List<string> { "Review privacy settings, be careful what you share online, use strong passwords, and understand privacy policies." } },
            { "what is gdpr?", new List<string> { "GDPR (General Data Protection Regulation) is a strict data protection law in the EU, giving individuals more control over their personal data." } },
            { "what is ccpa?", new List<string> { "CCPA (California Consumer Privacy Act) is a state statute intended to enhance privacy rights and consumer protection for residents of California." } },
            { "what is data breach?", new List<string> { "A data breach is a security incident where unauthorized individuals gain access to confidential or sensitive data." } },
            { "how to respond to data breach", new List<string> { "If your data is breached, change affected passwords, monitor your accounts, and consider freezing your credit." } },
            { "what is network security?", new List<string> { "Network security protects your network infrastructure and the data flowing over it from unauthorized access, misuse, or disruption." } },
            { "how to secure my wi-fi?", new List<string> { "Use strong, unique passwords for your Wi-Fi, enable WPA3 encryption if available, and regularly change default router credentials." } },
            { "what is a vpn?", new List<string> { "A VPN (Virtual Private Network) encrypts your internet connection and hides your IP address, enhancing online privacy and security." } },
            { "what is encryption?", new List<string> { "Encryption is the process of converting information or data into a code to prevent unauthorized access." } },
            { "what is a ddos attack?", new List<string> { "A DDoS (Distributed Denial of Service) attack floods a system with traffic to make it unavailable to legitimate users." } },
            { "what is port scanning?", new List<string> { "Port scanning is a technique used to identify open ports on a network, which can indicate vulnerabilities." } },
            { "how to improve home network security", new List<string> { "Change default router passwords, use strong Wi-Fi encryption, keep router firmware updated, and use a firewall." } },
            { "what is wpa2 wpa3?", new List<string> { "WPA2 and WPA3 are encryption protocols for Wi-Fi. WPA3 is the newest and most secure standard." } },
            { "what is incident response?", new List<string> { "Incident response is the organized approach to managing the aftermath of a cybersecurity breach or attack." } },
            { "why is incident response important?", new List<string> { "It helps minimize damage, reduce recovery costs, and ensure business continuity after a security incident." } },
            { "what are the stages of incident response?", new List<string> { "Preparation, Identification, Containment, Eradication, Recovery, and Lessons Learned." } },
            { "what is a security incident?", new List<string> { "A security incident is an event that compromises the confidentiality, integrity, or availability of an information system." } },
            { "how to report a cyber incident?", new List<string> { "Contact your IT security team, relevant authorities, or cybersecurity organizations, providing as many details as possible." } },
            { "what is a forensic investigation?", new List<string> { "A forensic investigation collects and analyzes evidence of a cyberattack to determine its cause, scope, and impact." } },
            { "what is a disaster recovery plan?", new List<string> { "A disaster recovery plan outlines how an organization will resume operations after an unexpected event, like a cyberattack." } },
            { "what is business continuity planning?", new List<string> { "Business continuity planning ensures essential business functions can continue during and after a disaster." } },
            { "hello", new List<string> {"Hello there!", "Hi! How can I help you with cybersecurity today?", "Greetings!"}},
            {"hi", new List<string> {"Hello there!", "Hi! How can I help you with cybersecurity today?", "Greetings!"}},
            {"how are you", new List<string> {"I'm a bot, so I don't have feelings, but I'm ready to help you learn about cybersecurity!", "I'm functioning perfectly, thanks for asking! How can I assist you?", "All systems go!"}},
            {"what's your purpose", new List<string> {"I am here to help you understand cybersecurity and stay safe online.", "My purpose is to educate users on cybersecurity awareness.", "I'm your friendly cybersecurity assistant!"}},
            {"what can i ask you about", new List<string> {"I can tell you about password safety, phishing, malware, two-factor authentication, and more! Just ask.", "Feel free to ask me anything related to cybersecurity, tasks, or even play a quiz!", "You can ask me about cybersecurity topics, manage tasks, or play a quiz."}},
            { "start quiz", new List<string> { "Alright, {0}, let's start the Cybersecurity Quiz! I'll ask you questions, and you provide the answers.", "Get ready for the quiz, {0}! Type your answers after each question." } },
            { "add task", new List<string> { "What task would you like to add, {0}? Please be specific.", "Tell me the task you want to add, {0}, and I'll remember it for you." } },
            { "show tasks", new List<string> { "Let me retrieve your current tasks for you, {0}.", "Here are the tasks you've added so far, {0}." } },
            { "complete task", new List<string> { "Which task number would you like to mark as complete, {0}?", "Please tell me the number of the task you finished, {0}." } },
            { "delete task", new List<string> { "Which task number would you like to delete, {0}?", "Enter the number of the task you wish to remove, {0}." } },
            { "show activity log", new List<string> { "Retrieving your recent activity log entries, {0}.", "Here's a summary of what we've done recently, {0}." } },
            { "view activity log", new List<string> { "Retrieving your recent activity log entries, {0}.", "Here's a summary of what we've done recently, {0}." } }
        };

        private readonly List<string> _defaultResponses = new List<string>
        {
            "I'm not sure I understand that, {0}. Can you try rephrasing?",
            "Could you please elaborate on that, {0}? I'm still learning!",
            "I didn't quite catch that, {0}. What would you like to know about cybersecurity?",
            "My apologies, {0}, I'm not familiar with that query. Is there a specific cybersecurity topic you're interested in?",
            "I'm designed to help with cybersecurity awareness, {0}. Perhaps you can ask me about passwords, phishing, or malware?"
        };

        public string GetResponse(string input, string userName)
        {
            string normalizedInput = input.ToLower().Trim();

            if (_responses.TryGetValue(normalizedInput, out List<string> possibleResponses))
            {
                string response = possibleResponses[_random.Next(possibleResponses.Count)];
                return string.Format(response, userName);
            }

            foreach (var entry in _responses)
            {
                if (normalizedInput.Contains(entry.Key))
                {
                    string response = entry.Value[_random.Next(entry.Value.Count)];
                    return string.Format(response, userName);
                }
            }

            return GetRandomDefaultResponse(userName);
        }

        public string GetRandomDefaultResponse(string userName)
        {
            string response = _defaultResponses[_random.Next(_defaultResponses.Count)];
            return string.Format(response, userName);
        }

        public string GetInitialGreeting()
        {
            return "Hello! I am your Cybersecurity Awareness Chatbot. How can I assist you today?";
        }
    }
}