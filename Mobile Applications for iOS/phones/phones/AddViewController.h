//
//  AddViewController.h
//  phones
//
//  Created by z on 1/28/16.
//  Copyright © 2016 z. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface AddViewController : UIViewController
@property (weak, nonatomic) IBOutlet UITextField *modelInput;
@property (weak, nonatomic) IBOutlet UITextField *manufacturerInput;
@property (weak, nonatomic) IBOutlet UITextField *ownerInput;
@property (weak, nonatomic) IBOutlet UITextField *priceInput;
@property (weak, nonatomic) IBOutlet UITextField *batteryInput;
@property (weak, nonatomic) IBOutlet UITextField *displayInput;

@end
