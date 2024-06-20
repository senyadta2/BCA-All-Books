import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Login implements ActionListener {
    JFrame jFrame = new JFrame("Log in");
    JLabel userLb = new JLabel("Username");
    JLabel passLb = new JLabel("Password");
    JTextField userTF = new JTextField();
    JTextField passTf = new JTextField();
    JLabel message = new JLabel();

    @Override
    public void actionPerformed(ActionEvent e) {
        if(userTF.getText().equals("admin") && passTf.getText().equals("admin"))
        {
            message.setText("Login succes");
        }
        else {
            message.setText("Login not success");
        }
    }

    Login(){
        userLb.setBounds(10,10,100,20);
        userTF.setBounds(90,10,100,20);
        passLb.setBounds(10,30,100,20);
        passTf.setBounds(90,30,100,20);
        JButton button = new JButton("Log in");
        button.setBounds(60,50,100,20);
        button.addActionListener(this);
        message.setBounds(100,50,200,300);
        jFrame.add(userLb);
        jFrame.add(userTF);
        jFrame.add(passTf);
        jFrame.add(passLb);
        jFrame.add(button);
        jFrame.add(message);

        jFrame.setSize(500,500);
        jFrame.setLayout(null);
        jFrame.setVisible(true);
    }

    public static void main(String[] args) {
        new Login();
    }
}
