//
//  AddViewController.m
//  phones
//
//  Created by z on 1/28/16.
//  Copyright © 2016 z. All rights reserved.
//

#import "AddViewController.h"
#import "MainViewController.h"
#import "GSM.h"

@interface AddViewController (){
    GSM* gsm;
}

@end

@implementation AddViewController

- (void)viewDidLoad {
    [super viewDidLoad];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

-(void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender{
    
    NSString* detailSegueIdentifier = @"addSegue";
    NSString* model = self.modelInput.text;
    NSString* manufacturer = self.manufacturerInput.text;
    NSString* owner = self.ownerInput.text;
    double price = [self.priceInput.text doubleValue];
    
    if (model.length == 0 || manufacturer.length ==0) {
        [[[UIAlertView alloc] initWithTitle:@"Missing data" message:@"model and manufacturer are required" delegate:self cancelButtonTitle:@"ok" otherButtonTitles: nil] show];
        return;
    }
    
    gsm = [GSM gsmWithModel:model Manufacturer:manufacturer Owner:owner Price:price Battery:nil andDisplay:nil];    
    
    if ([segue.identifier isEqualToString:detailSegueIdentifier]) {
        MainViewController* toVC = segue.destinationViewController;
        toVC.gsm = gsm;
    }
}

@end
